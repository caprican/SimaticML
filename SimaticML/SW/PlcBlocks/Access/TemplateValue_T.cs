using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("TemplateValue", Namespace = "", IsNullable = false)]
    public class TemplateValue_T
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public TemplateType_TE Type { get; set; }

        [XmlText]
        public string Value { get; set; }

        /// <remarks>add on v2</remarks>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
