using System;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class NetworkSource_T
    {
        [XmlElement(Type = typeof(SW.PlcBlocks.SCL.StructuredText_T_v2), ElementName = "StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v2")]
        [XmlElement(Type = typeof(SW.PlcBlocks.SCL.StructuredText_T_v3), ElementName = "StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
        [XmlElement(Type = typeof(SW.PlcBlocks.SCL.StructuredText_T_v4), ElementName = "StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v4")]
        public SW.PlcBlocks.SCL.StructuredText_T[] StructuredText { get; set; }
    }
}
