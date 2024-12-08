using System;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    public enum ProgrammingContext_TE
    {
        Plain,
        GraphTransition,
        GraphSupervision,
        GraphInterlock,
        GraphActions,
        PreOperation,
        PostOperation
    }
}
