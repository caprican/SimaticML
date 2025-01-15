using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("NamelessParameter", Namespace = "", IsNullable = false)]
    public class NamelessParameter_T
    {
        /// <summary>
        /// for InterfaceFlags. InterfaceFlags is informative
        /// The type of the value should be InterfaceFlags_TP
        /// The default value is "S7_Visible"
        /// </summary>
        [XmlElement("StringAttribute")]
        public Common.StringAttribute_T_v2[] StringAttribute { get; set; }

        [XmlElement("Access", typeof(Access_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("NamelessParameter", Namespace = "", IsNullable = false)]
    public class NamelessParameter_T_v3 : NamelessParameter_T
    {
        [XmlElement("Access", typeof(Access_T_v3))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("NamelessParameter", Namespace = "", IsNullable = false)]
    public class NamelessParameter_T_v4 : NamelessParameter_T_v3
    {
        [XmlElement("Access", typeof(Access_T_v4))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("NamelessParameter", Namespace = "", IsNullable = false)]
    public class NamelessParameter_T_v5 : NamelessParameter_T_v4
    {
        [XmlElement("Access", typeof(Access_T_v5))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }
}
