using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.SCL
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL => SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", Namespace = "", IsNullable = false)]
    public class StructuredText_T
    {
        [XmlElement("Access", typeof(Access.Access_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v2))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL_v2 => SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", Namespace = "", IsNullable = false)]
    public class StructuredText_T_v2 : StructuredText_T
    {
        [XmlElement("Access", typeof(Access.Access_T_v3))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v3))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL_v3 => SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", Namespace = "", IsNullable = false)]
    public class StructuredText_T_v3 : StructuredText_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T_v4))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v4))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL_v4 => SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", Namespace = "", IsNullable = false)]
    public class StructuredText_T_v4 : StructuredText_T_v3
    {
        [XmlElement("Access", typeof(Access.Access_T_v5))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v5))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }
}
