namespace Artillery.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.DataProcessor.ImportDto;
    using Newtonsoft.Json;
    using AutoMapper;
    using System.Linq;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;
    using Artillery.Data.Models.Enums;
    using System.Xml.Serialization;
    using System.IO;

    public class Deserializer
    {
        private const string ErrorMessage =
                "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {

            var xmlSerializer = new XmlSerializer(typeof(ImportCountryDto[]), new XmlRootAttribute("Songs"));
            var countriesDto = (ImportCountryDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var countries = new List<Country>();
            var sb  = new StringBuilder();

            foreach (var countryDto in countriesDto)
            {
                var country = Mapper.Map<Country>(countryDto);
                bool isValiCountry = IsValid(country);

                if (isValiCountry == false)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                countries.Add(country);
            }

            return sb.ToString();

        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(ImportShellDto[]), new XmlRootAttribute("Shells"));

            var shellssDto = (ImportShellDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var shellss = new List<Shell>();

            foreach (var shellDto in shellssDto)
            {
                var shell = Mapper.Map<Shell>(shellDto);

                bool isValidShell = IsValid(shell);

                if (isValidShell == false)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

            }
        }

        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            var gunsDto = JsonConvert.DeserializeObject<ImportGunsDto[]>(jsonString);

            var guns = new List<Gun>();

            var sb = new StringBuilder();

            foreach (var gunDto in gunsDto)
            {
                bool isValidGenre = Enum.IsDefined(typeof(GunType), gunDto.GetType());

                var shells = context.Shels.Find(gunDto.ShellId);
                var manufacturer = context.Manufacturers.Find(gunDto.ManufacturerId);

                if (isValidGenre == false || shells == null || manufacturer == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var gun = Mapper.Map<Gun>(gunDto);   

                var countriesGuns = gunDto.CountriesGuns.Select(x => Mapper.Map<CountryGun>(x)).ToList();

                bool isValidGun = IsValid(gun);

                if (isValidGun == false)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                gun.CountriesGuns = countriesGuns;

                guns.Add(gun);

                
            }

            context.AddRange(guns);

            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
