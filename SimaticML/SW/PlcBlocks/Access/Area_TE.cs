using System;

namespace SimaticML.SW.PlcBlocks.Access
{
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
