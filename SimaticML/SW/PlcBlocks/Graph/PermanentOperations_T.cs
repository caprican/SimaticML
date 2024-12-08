using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("PostOperations", Namespace = "", IsNullable = false)]
    public class PermanentOperations_T
    {
        public Common.Comment_T Title { get; set; }

        public Common.Comment Comment { get; set; }

        [XmlElement("PermanentOperation")]
        public PermanentOperation_T[] PermanentOperation { get; set; }
    }
}
