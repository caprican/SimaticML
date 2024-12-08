using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("IdentCon", Namespace = "", IsNullable = false)]
    public class IdentCon_T
    {
        [XmlAttribute]
        public int UId { get; set; }
    }
}
