using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [XmlInclude(typeof(StructuredTagAccessType))]
    [XmlInclude(typeof(MultiInstAccessType))]
    [XmlInclude(typeof(InterfaceAccessType))]
    [XmlInclude(typeof(DataTypeAccessType))]
    [XmlInclude(typeof(GlobalAccessType))]
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class SimaticStorageType
    {
        [XmlElement("AccessObject")]
        public AccessObjectType[] AccessObject { get; set; }

        [XmlAttribute()]
        public string AccessModifier { get; set; }
    }
}
