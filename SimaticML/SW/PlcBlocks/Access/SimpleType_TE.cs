using System;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
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
