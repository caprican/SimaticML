using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Sequence", Namespace = "", IsNullable = false)]
    public class Sequence_T
    {
        public Comment_T Title { get; set; }

        public Comment Comment { get; set; }

        public Steps_T Steps { get; set; }

        public Transitions_T Transitions { get; set; }

        public Branches_T Branches { get; set; }

        public Connections_T Connections { get; set; }
    }
}
