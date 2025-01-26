using System;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    public enum SectionName_TE
    {
        None,
        Input,
        Return,
        Output,
        InOut,
        Static,
        Temp,
        Constant,
        Base
    }
}
