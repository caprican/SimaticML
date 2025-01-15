using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions
    ///          SW.PlcBlocks.TypeSupervisions_v2
    ///          SW.PlcBlocks.TypeSupervisions_v3
    /// </remarks>
    [Serializable]
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
