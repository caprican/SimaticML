using System;
using System.Xml.Serialization;

namespace SimaticML.SW
{
    [Serializable]
    public class Interface_T
    {
        [XmlArray]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Section_T) , IsNullable = false, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v2")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Section_T_v3) , IsNullable = false, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v3")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Section_T_v3) , IsNullable = false, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Section_T_v5) , IsNullable = false, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v5")]
        public InterfaceSections.Section_T[] Sections { get; set; }
    }
}
