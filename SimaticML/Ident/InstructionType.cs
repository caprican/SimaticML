using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class InstructionType
    {
        [XmlElement("Parameter")]
        public LibraryParameterType[] Parameter { get; set; }

        [XmlElement("TemplateParameterInfo")]
        public TemplateParameterInfoType[] TemplateParameterInfo { get; set; }

        public InstructionUsages_Type InstructionUsages { get; set; }

        [XmlAttribute]
        public string LibraryObjId { get; set; }

        [XmlAttribute]
        public string VersionId { get; set; }

        [XmlAttribute]
        public string NeedsInstance { get; set; }

        [XmlAttribute]
        public string CompatibleVersionId { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string SymbolInformation { get; set; }
    }
}
