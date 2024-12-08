using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("OpenCon", Namespace = "", IsNullable = false)]
    public class OpenCon_T
    {
        [XmlAttribute]
        public int UId { get; set; }
    }
}
