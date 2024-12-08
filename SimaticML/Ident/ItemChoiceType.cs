using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        Address,
        Alarm,
        AufDBBlock,
        BlockInterfaceInfo,
        CBBlock,
        Constant,
        DataTypeAccess,
        DataTypeBlock,
        DepDBBlock,
        DirectType,
        Expression,
        FBBlock,
        FBTBlock,
        FCBlock,
        GlobalAccess,
        Ident,
        IndirectDBAccess,
        Instruction,
        InterfaceAccess,
        Label,
        MTHBlock,
        MultiInstanceAccess,
        NamedValue,
        NamedValueType,
        OBBlock,
        ReferenceOperand,
        SimaticStorage,
        SimpleAccess,
        StructuredTagAccess,
        ThisBlock,
    }
}
