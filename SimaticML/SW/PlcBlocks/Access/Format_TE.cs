using System;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    public enum Format_TE
    {
        Real,
        Bin,
        DecSigned,
        DecUnsigned,
        Pointer,
        CharSequence,
        DecSequence,
        Hex,
        S5Count,
        Time,
        Date,
        TimeOfDay,
        S5Time,
        Bool,
        Oct,
        Bcd,
        DateAndTime,
        String,
        Any,
        Number,
        Char,
        HexSequence
    }
}
