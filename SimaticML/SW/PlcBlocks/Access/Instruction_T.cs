using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T
    {
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("Instance", typeof(Instance_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T))]
        [XmlElement("TemplateValue", typeof(TemplateValue_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

}
