using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 0 | 2)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 0 | 2)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 1)]
        [XmlElement("TemplateValue", typeof(TemplateValue_T), Order = 3)]
        [XmlElement("Instance", typeof(Instance_T), Order = 4)]
        [XmlElement("Parameter", typeof(Parameter_T), Order = 5)]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v2 : Instruction_T
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3 | 6 | 9)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3 | 6 | 9)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3 | 6 | 9)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3 | 6 | 9)]
        [XmlElement("TemplateValue", typeof(TemplateValue_T_v2), Order = 0)]
        [XmlElement("Token", typeof(Common.Token_T_v2), Order = 0 | 2 | 5 | 8)]
        [XmlElement("Instance", typeof(Instance_T_v2), Order = 1)]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T), Order = 4)]
        [XmlElement("Parameter", typeof(Parameter_T_v2), Order = 7)]
        public new object[] Items { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v3 : Instruction_T_v2
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("Instance", typeof(Instance_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T_v3))]
        [XmlElement("TemplateValue", typeof(TemplateValue_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v4 : Instruction_T_v3
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("Instance", typeof(Instance_T_v4))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T_v4))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T_v4))]
        [XmlElement("TemplateValue", typeof(TemplateValue_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v5 : Instruction_T_v4
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("Instance", typeof(Instance_T_v5))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T_v5))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T_v5))]
        [XmlElement("TemplateValue", typeof(TemplateValue_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }
}
