using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class InstructionUsage_Type
    {
        [XmlElement("Location")]
        public Location_Type[] Location { get; set; }

        [XmlElement("ImplementationDetails")]
        public ImplementationDetails_Type[] ImplementationDetails { get; set; }

        [XmlElement("TemplateValue")]
        public TemplateValue_Type[] TemplateValue { get; set; }
    }
}
