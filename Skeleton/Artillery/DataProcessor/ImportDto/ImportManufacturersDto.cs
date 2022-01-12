namespace Artillery.DataProcessor.ImportDto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlType("Manufacturer")]
    public class ImportManufacturersDto
    {
        [XmlElement( ElementName = "ManufacturerName ")]
        public string ManufacturerName { get; set; }


       [XmlElement(ElementName = "Founded")]
        public string Founded { get; set; }
    }
}
