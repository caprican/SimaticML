using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Expression", Namespace = "", IsNullable = false)]
    public class Expression_T
    {
        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Token", typeof(Common.Token_T))]
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Expression", Namespace = "", IsNullable = false)]
    public class Expression_T_v2 : Expression_T
    {
        [XmlElement("Access", typeof(Access_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Expression", Namespace = "", IsNullable = false)]
    public class Expression_T_v3 : Expression_T_v2
    {
        [XmlElement("Access", typeof(Access_T_v3))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Expression", Namespace = "", IsNullable = false)]
    public class Expression_T_v4 : Expression_T_v2
    {
        [XmlElement("Access", typeof(Access_T_v4))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Expression", Namespace = "", IsNullable = false)]
    public class Expression_T_v5 : Expression_T_v4
    {
        [XmlElement("Access", typeof(Access_T_v5))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }
    }
}
