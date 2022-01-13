
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {





            //var gunsDto = context.Guns.
            //    Where(g => g.Shell.ShellWeight > shellWeight
            //    && g.GunType.ToString() == "AntiAircraftGun")
            //    .OrderByDescending(g => g.GunWeight)
            //    .Select(g => new ExportGunDto
            //    {
            //        GunType = g.GunType.ToString(),
            //        GunWeight = g.GunWeight,
            //        BarelLength = g.BarrelLength,
            //        Range = g.Range
            //    })
            //    .ToList();

            var shellsDto = context.Shels
                .Where(s => s.ShellWeight > shellWeight)
                .Select(s => new ExportShellsDto
                {
                    ShellWeight = s.ShellWeight,
                    Caliber = s.Caliber,
                    Guns = s.Guns
                           .Where(g => g.Shell.ShellWeight > shellWeight
                           && g.GunType.ToString() == "AntiAircraftGun")
                          .OrderByDescending(g => g.GunWeight)
                          .Select(g => new ExportGunDto
                          {
                              GunType = "a",
                              GunWeight = g.GunWeight,
                              BarelLength = g.BarrelLength,
                              Range = g.Range
                          })
                          .ToList()
                })
                .OrderBy(s => s.ShellWeight)
                .ToList();







            var json = JsonConvert.SerializeObject(shellsDto, Formatting.Indented);

            return json;


        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {

            var exportGun = context.Guns
                .Where(g => g.Manufacturer.ManufacturerName == manufacturer)
                .Select(g => new ExportGunSDtoXml
                {
                    Manifacturer = g.Manufacturer.ManufacturerName,
                    GunType = g.GunType.ToString(),
                    GunWeight = g.GunWeight,
                    BarrelLength = g.BarrelLength,
                    Range = g.Range,
                    Countries =g.CountriesGuns
                   .Where(c => c.Country.ArmySize > 4500000)
                   .Select(c => new CountryDto
                   {
                       CountryName = c.Country.CountryName,
                       ArmySize = c.Country.ArmySize

                   })
                   .OrderBy(c => c.ArmySize)
                   .ToArray()


                })
                .OrderBy(x => x.BarrelLength)
                .ToList();

            throw new NotImplementedException();
        }
    }
}
