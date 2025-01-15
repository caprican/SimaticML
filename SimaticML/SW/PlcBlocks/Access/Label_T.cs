using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>SCL only</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Label", Namespace = "", IsNullable = false)]
    public class Label_T
    {
        [XmlAttribute]
        public string Name { get; set; }
    }

    /// <summary>SCL only</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Label", Namespace = "", IsNullable = false)]
    public class Label_T_v2 : Label_T
    {
        public Common.BooleanAttribute_T_v2 BooleanAttribute { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public Common.Comment_G[] Items { get; set; }

        public Common.Token_T_v2 Token { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <summary>SCL only</summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Label", Namespace = "", IsNullable = false)]
    public class Label_T_v4 : Label_T_v2
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Common.Comment_G[] Items { get; set; }
    }
}
