using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;
using SimaticML.SW.PlcBlocks.LADFBD;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("PermanentOperation", Namespace = "", IsNullable = false)]
    public class PermanentOperation_T
    {
        public Comment_T Title { get; set; }

        public FlgNet_T FlgNet { get; set; }

        [XmlAttribute]
        public ProgrammingLanguage_TE ProgrammingLanguage { get; set; }
    }
}
