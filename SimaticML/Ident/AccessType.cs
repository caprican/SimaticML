using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable()]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class AccessType
    {
        [XmlElement("Address", typeof(AddressType))]
        [XmlElement("Alarm", typeof(AlarmType))]
        [XmlElement("AufDBBlock", typeof(AufDBBlockType))]
        [XmlElement("BlockInterfaceInfo", typeof(BlockInterfaceInfoType))]
        [XmlElement("CBBlock", typeof(CBBlockType))]
        [XmlElement("Constant", typeof(ConstantType))]
        [XmlElement("DataTypeAccess", typeof(DataTypeAccessType))]
        [XmlElement("DataTypeBlock", typeof(DataTypeBlockType))]
        [XmlElement("DepDBBlock", typeof(DepDBBlockType))]
        [XmlElement("DirectType", typeof(DirectTypeType))]
        [XmlElement("Expression", typeof(ExpressionType))]
        [XmlElement("FBBlock", typeof(FBBlockType))]
        [XmlElement("FBTBlock", typeof(FBTBlockType))]
        [XmlElement("FCBlock", typeof(FCBlockType))]
        [XmlElement("GlobalAccess", typeof(GlobalAccessType))]
        [XmlElement("Ident", typeof(EmptyIdentType))]
        [XmlElement("IndirectDBAccess", typeof(IndirectDBAccessType))]
        [XmlElement("Instruction", typeof(InstructionType))]
        [XmlElement("InterfaceAccess", typeof(InterfaceAccessType))]
        [XmlElement("Label", typeof(object))]
        [XmlElement("MTHBlock", typeof(MTHBlockType))]
        [XmlElement("MultiInstanceAccess", typeof(MultiInstAccessType))]
        [XmlElement("NamedValue", typeof(NamedValueType))]
        [XmlElement("NamedValueType", typeof(NamedValueTypeType))]
        [XmlElement("OBBlock", typeof(OBBlockType))]
        [XmlElement("ReferenceOperand", typeof(ReferenceOperandType))]
        [XmlElement("SimaticStorage", typeof(SimaticStorageType))]
        [XmlElement("SimpleAccess", typeof(SimpleAccessType))]
        [XmlElement("StructuredTagAccess", typeof(StructuredTagAccessType))]
        [XmlElement("ThisBlock", typeof(object))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }

        [XmlIgnore]
        public ItemChoiceType ItemElementName { get; set; }
    }
}
