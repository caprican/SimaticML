using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("NameCon", Namespace = "", IsNullable = false)]
    public class NameCon_T
    {
        [XmlAttribute]
        public int UId { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
    }
}
