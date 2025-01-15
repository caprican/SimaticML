using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", Namespace = "", IsNullable = false)]
    public class Parameter_T
    {
        [XmlElement("IntegerAttribute" , typeof(Common.IntegerAttribute_T), Order = 0)]                // for NumBLs. NumBLs is informative
        [XmlElement("StringAttribute", typeof(Common.StringAttribute_T), Order = 1)]                   // for InterfaceFlags. InterfaceFlags is informative. The type of the value should be InterfaceFlags_TP. The default value is "S7_Visible"
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        [XmlElement("Access", typeof(Access_T), Order = 3)]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public Common.SectionName_TE Section { get; set; }
        [XmlIgnore]
        public bool SectionSpecified { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TemplateReference { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", Namespace = "", IsNullable = false)]
    public class Parameter_T_v2 : Parameter_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        [XmlElement]
        public Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        /// <summary>
        /// for InterfaceFlags. InterfaceFlags is informative
        /// The type of the value should be InterfaceFlags_TP
        /// The default value is "S7_Visible"
        /// </summary>
        [XmlElement]
        public Common.StringAttribute_T_v2 StringAttribute { get; set; }

        [XmlElement("BooleanAttribute")]
        public Common.BooleanAttribute_T_v2[] BooleanAttribute { get; set; }

        [XmlElement("Access", typeof(Access_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", Namespace = "", IsNullable = false)]
    public class Parameter_T_v3 : Parameter_T_v2
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
    [XmlRoot("Parameter", Namespace = "", IsNullable = false)]
    public class Parameter_T_v4 : Parameter_T_v3
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
    [XmlRoot("Parameter", Namespace = "", IsNullable = false)]
    public class Parameter_T_v5 : Parameter_T_v4
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
