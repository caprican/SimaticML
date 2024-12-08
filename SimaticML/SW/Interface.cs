using System;
using System.Xml.Serialization;

namespace SimaticML.SW
{
    [Serializable]
    public class Interface_T
    {
        [XmlArray(Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v5")]
        [XmlArrayItem("Section", IsNullable = false)]
        public InterfaceSections.Section_T[] Sections { get; set; }
    }
}
