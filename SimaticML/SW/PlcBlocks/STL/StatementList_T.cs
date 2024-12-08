using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.STL
{
    [Serializable]
    [XmlRoot("StatementList", Namespace = "", IsNullable = false)]
    public class StatementList_T
    {
        [XmlElement("StlStatement")]
        public StlStatement_T[] StlStatement { get; set; }
    }
}
