namespace Artillery.DataProcessor.ExportDto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlType("Gun")]
    public class ExportGunSDtoXml
    {
        [XmlElement(ElementName = "Manifacturer")]
        public string Manifacturer { get; set; }

        [XmlElement(ElementName = "GunType")]
        public string GunType { get; set; }

        [XmlElement(ElementName = "BarrelLength")]
        public double BarrelLength { get; set; }

        [XmlElement(ElementName = "GunWeight")]
        public int GunWeight { get; set; }

        [XmlElement(ElementName = "Range")]
        public double Range { get; set; }

        [XmlElement(ElementName = "Countries")]
        public CountryDto[] Countries { get; set; }
    }
}
