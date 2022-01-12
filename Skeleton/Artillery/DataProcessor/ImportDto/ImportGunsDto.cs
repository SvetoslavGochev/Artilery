namespace Artillery.DataProcessor.ImportDto
{
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ImportGunsDto
    {
        [JsonProperty("ManufacturerId")]
        public int ManufacturerId { get; set; }


        [JsonProperty("GunWeight")]
        public int GunWeight { get; set; }

        [JsonProperty("BarrelLength")]
        public double BarrelLength { get; set; }

        [JsonProperty("NumberBuild")]
        public int NumberBuild { get; set; }

        [JsonProperty("Range")]
        public int Range { get; set; }

        [JsonProperty("GunType")]
        public string GunType { get; set; }


        [JsonProperty("ShellId")]
        public int ShellId { get; set; }



        [JsonProperty("CountriesGuns")]
        public ICollection<CountryGun> CountriesGuns { get; set; } 
    }
}
