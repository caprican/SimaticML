using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Wire", Namespace = "", IsNullable = false)]
    public class Wire_T
    {
        [XmlElement("IdentCon", typeof(IdentCon_T))]
        [XmlElement("NameCon", typeof(NameCon_T))]
        [XmlElement("OpenCon", typeof(OpenCon_T))]
        [XmlElement("Openbranch", typeof(Openbranch_T))]
        [XmlElement("Powerrail", typeof(Powerrail_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
    }
}
