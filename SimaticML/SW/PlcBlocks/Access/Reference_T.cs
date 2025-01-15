using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>SCL</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class Reference_T
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 2 | 4)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 2 | 4)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 1 | 5)]
        [XmlElement("Access", typeof(Access_T_v2), Order = 3)]
        public object[] Items { get; set; }
    }

    /// <summary>SCL</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class Reference_T_v3 : Reference_T
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 2 | 4)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 2 | 4)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 1 | 5)]
        [XmlElement("Access", typeof(Access_T_v3), Order = 3)]
        public new object[] Items { get; set; }
    }

    /// <summary>SCL</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class Reference_T_v4 : Reference_T_v3
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 2 | 4)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 0 | 2 | 4)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 1 | 5)]
        [XmlElement("Access", typeof(Access_T_v4), Order = 3)]
        public new object[] Items { get; set; }
    }

    /// <summary>SCL</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class Reference_T_v5 : Reference_T_v4
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 2 | 4)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 0 | 2 | 4)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 1 | 5)]
        [XmlElement("Access", typeof(Access_T_v5), Order = 3)]
        public new object[] Items { get; set; }
    }
}
