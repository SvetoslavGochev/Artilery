namespace Artillery.DataProcessor.ImportDto
{
    using Artillery.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlType("Shell")]
    public class ImportShellDto
    {
        [XmlElement(ElementName = "ShellWeight")]
        public string ShellWeight { get; set; }

        [XmlElement(ElementName = "Caliber")]
        public string Caliber { get; set; }

        //[XmlArray("Guns")]
        //public Gun[] Guns { get; set; }

    }
}
