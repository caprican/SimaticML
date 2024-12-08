using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("IdentRef", Namespace = "", IsNullable = false)]
    public class IdentRef_T
    {
        public Comment Comment { get; set; }

        public ViewInfo_T ViewInfo { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
    }
}
