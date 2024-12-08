using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    public enum Qualifier_TE
    {
        [XmlEnum("")]
        Item,
        CD,
        CR,
        CS,
        CU,
        D,
        L,
        N,
        ON,
        OFF,
        R,
        S,
        TD,
        TF,
        TL,
        TR
    }
}
