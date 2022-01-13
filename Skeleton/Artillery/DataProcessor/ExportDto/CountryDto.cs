namespace Artillery.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Countries")]
    public class CountryDto
    {
        [XmlElement(ElementName = "CountryName")]
        public string CountryName { get; set; }

        [XmlElement(ElementName = "ArmySize")]
        public int ArmySize { get; set; }
    }
}