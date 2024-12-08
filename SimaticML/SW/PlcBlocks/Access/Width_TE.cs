using System;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    public enum Width_TE
    {
        None,
        Bit,
        Byte,
        Word,
        Offset,
        Double,
        Pointer,
        Long,
        Any,
        Block
    }
}
