﻿using System;

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
    /// <item></item>
    /// <item></item>
    /// </list>
    /// </remarks>
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
