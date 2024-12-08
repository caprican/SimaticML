using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    [Serializable]
    //[XmlRoot("StartValue", Namespace = "", IsNullable = false)]
    public class StartValue_T
    {
        public StartValue_T()
        {
            IsBulkValue = false;
            Informative = false;
        }

        [XmlAttribute]
        public string ConstantName { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsBulkValue { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

}
