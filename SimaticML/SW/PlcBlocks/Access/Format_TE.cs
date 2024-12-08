using System;

namespace SimaticML.SW.PlcBlocks.Access
{
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
