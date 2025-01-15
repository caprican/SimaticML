using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", Namespace = "", IsNullable = false)]
    public class Indirect_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        [XmlElement("Token", typeof(Common.Token_T))]
        public object[] Items { get; set; }

        public Access_T Access { get; set; }

        [XmlAttribute]
        public Width_TE Width { get; set; }

        [XmlAttribute]
        public Area_TE Area { get; set; }
        [XmlIgnore]
        public bool AreaSpecified { get; set; }

        [XmlAttribute]
        public Register_TE Register { get; set; }
        [XmlIgnore]
        public bool RegisterSpecified { get; set; }

        [XmlAttribute]
        public string BitOffset { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", Namespace = "", IsNullable = false)]
    public class Indirect_T_v2 : Indirect_T
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }

        public new Access_T_v2 Access { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", Namespace = "", IsNullable = false)]
    public class Indirect_T_v3 : Indirect_T_v2
    {
        public new Access_T_v3 Access { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", Namespace = "", IsNullable = false)]
    public class Indirect_T_v4 : Indirect_T_v3
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }

        public new Access_T_v4 Access { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", Namespace = "", IsNullable = false)]
    public class Indirect_T_v5 : Indirect_T_v4
    {
        public new Access_T_v5 Access { get; set; }
    }
}
