using System;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Path { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T_v2 : Subelement_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T_v5 : Subelement_T_v2
    {
        [XmlElement("AssignedProDiagFB", typeof(string))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public new object[] Items { get; set; }
    }
}
