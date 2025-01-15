using System;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    ///          SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    public enum Area_TE
    {
        None,
        PeripheryInput,
        PeripheryOutput,
        Input,
        Output,
        Memory,
        FB,
        FC,

        /// <summary>
        /// partly qualified access with DB register
        /// </summary>
        DB,

        /// <summary>
        /// partly qualified access with DI register
        /// </summary>
        DI,
        Timer,
        Counter,

        /// <summary>
        /// Classic Local Stack
        /// </summary>
        Local
    }
}
