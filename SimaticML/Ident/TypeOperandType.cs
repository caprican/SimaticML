using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [XmlInclude(typeof(FBTBlockType))]
    [XmlInclude(typeof(DataTypeBlockType))]
    [XmlInclude(typeof(DepDBBlockType))]
    [XmlInclude(typeof(AufDBBlockType))]
    [XmlInclude(typeof(MTHBlockType))]
    [XmlInclude(typeof(CBBlockType))]
    [XmlInclude(typeof(OBBlockType))]
    [XmlInclude(typeof(FCBlockType))]
    [XmlInclude(typeof(FBBlockType))]
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class TypeOperandType
    {
        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public uint BlockNumber { get; set; }

        [XmlAttribute]
        public string BlockType { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TypeName { get; set; }

        [XmlAttribute]
        public int RId { get; set; }

        [XmlAttribute]
        public string StructureModifiedTS { get; set; }

        [XmlAttribute]
        public string TrackingGuid { get; set; }

        [XmlAttribute]
        public string VersionId { get; set; }

        [XmlAttribute]
        public string TypeObjectId { get; set; }

        [XmlAttribute]
        public string HasNamespace { get; set; }
    }
}
