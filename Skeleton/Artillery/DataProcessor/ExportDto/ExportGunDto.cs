namespace Artillery.DataProcessor.ExportDto
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExportGunDto
    {

        [JsonProperty("GunType")]
        public string GunType   { get; set; }


        [JsonProperty("GunWeight")]
        public int GunWeight { get; set;}

      
        [JsonProperty("BarelLength")]
        public double BarelLength { get; set;}

        [JsonProperty("Range")]
        public int Range { get; set;}
    }
}
