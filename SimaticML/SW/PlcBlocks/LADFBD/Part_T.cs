using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Part", Namespace = "", IsNullable = false)]
    public class Part_T
    {
        public Part_T()
        {
            DisabledENO = false;
        }

        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T))]
        public object Item { get; set; }

        [XmlElement("TemplateValue")]
        public Access.TemplateValue_T[] TemplateValue { get; set; }

        [XmlElement("AutomaticTyped")]
        public AutomaticTyped_T[] AutomaticTyped { get; set; }

        [XmlElement("Invisible")]
        public Invisible_T[] Invisible { get; set; }

        [XmlElement("Negated")]
        public Neg_T[] Negated { get; set; }

        public Common.Comment Comment { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool DisabledENO { get; set; }
    }
}
