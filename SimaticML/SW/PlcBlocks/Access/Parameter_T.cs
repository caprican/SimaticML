using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("Parameter", Namespace = "", IsNullable = false)]
    public class Parameter_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        [XmlElement]
        public IntegerAttribute_T IntegerAttribute { get; set; }

        /// <summary>
        /// for InterfaceFlags. InterfaceFlags is informative
        /// The type of the value should be InterfaceFlags_TP
        /// The default value is "S7_Visible"
        /// </summary>
        [XmlElement]
        public StringAttribute_T StringAttribute { get; set; }

        [XmlElement("BooleanAttribute")]
        public BooleanAttribute_T[] BooleanAttribute { get; set; }

        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public SectionName_TE Section { get; set; }
        [XmlIgnore]
        public bool SectionSpecified { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TemplateReference { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
