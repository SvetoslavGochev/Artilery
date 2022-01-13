namespace Artillery.DataProcessor.ExportDto
{
    using Artillery.Data.Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExportShellsDto
    {
        [JsonProperty("ShellWeight")]
        public double ShellWeight { get; set; }

        [JsonProperty("Caliber")]
        public string Caliber { get; set; }

        [JsonProperty("Guns")]
        public ICollection<ExportGunDto> Guns { get; set; }


    }
}
