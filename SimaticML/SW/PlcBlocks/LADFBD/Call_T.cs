using System;
using System.Xml.Serialization;

using SimaticML.SW.PlcBlocks.Access;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Call", Namespace = "", IsNullable = false)]
    public class Call_T
    {
        public CallInfo_T CallInfo { get; set; }

        [XmlElement("TemplateValue")]
        public TemplateValue_T[] TemplateValue { get; set; }

        [XmlElement("AutomaticTyped")]
        public AutomaticTyped_T[] AutomaticTyped { get; set; }

        [XmlElement("Invisible")]
        public Invisible_T[] Invisible { get; set; }

        [XmlElement("Negated")]
        public Neg_T[] Negated { get; set; }

        public Common.Comment Comment { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
    }
}
