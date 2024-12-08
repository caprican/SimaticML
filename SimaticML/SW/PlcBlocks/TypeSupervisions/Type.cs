using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    public enum Type
    {
        Action,
        Interlock,
        Operand,
        Position,
        Reaction,
        MessageText,
        MessageError
    }
}
