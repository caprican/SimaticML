using System;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class NetworkSource_T
    {
        //[XmlElement("StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v2")]
        //[XmlElement("StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
        [XmlElement("StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v4")]
        public SW.PlcBlocks.SCL.StructuredText_T[] StructuredText { get; set; }
    }
}
