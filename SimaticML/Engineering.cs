using System;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class Engineering
    {
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
