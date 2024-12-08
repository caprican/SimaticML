using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class DocumentInfo
    {
        public DateTime Created { get; set; }

        public string ExportSetting { get; set; }

        [XmlArray("InstalledProducts")]
        [XmlArrayItem("OptionPackage", typeof(InstalledProduct.OptionPackage))]
        [XmlArrayItem("Product", typeof(InstalledProduct.Product))]
        public InstalledProduct[] InstalledProducts { get; set; }
    }
}
