using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    public enum Event_TE
    {
        [XmlEnum("")]
        Item,
        A1,
        L0,
        L1,
        R1,
        S0,
        S1,
        V0,
        V1
    }
}
