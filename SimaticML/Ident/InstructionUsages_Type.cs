using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class InstructionUsages_Type
    {
        [XmlElement("InstructionUsage")]
        public InstructionUsage_Type[] InstructionUsage { get; set; }
    }
}
