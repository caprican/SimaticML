using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public Object_G[] Items { get; set; }

        [XmlAttribute]
        public string Path { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T_v3 : Subelement_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T_v5 : Subelement_T_v3
    {
        [XmlElement("AssignedProDiagFB", typeof(string))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public new object[] Items { get; set; }
    }
}
