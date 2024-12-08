using System;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    public enum SimpleType_TE
    {
        undef,
        Bool,
        Byte,
        Char,
        Word,
        Int,
        DWord,
        DInt,
        Real,
        LReal,
        Timer,
        S5Time,
        ARef,
        Any,
        Time,
        S5Count,
        Counter,
        Block_DB,
        Block_FB,
        Block_FC,
        Block_SFB,
        Block_UDT,
        Multi_FB,
        Multi_SFB
    }
}
