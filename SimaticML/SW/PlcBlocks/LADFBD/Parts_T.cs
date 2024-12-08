using System;
using System.Xml.Serialization;

using SimaticML.SW.PlcBlocks.Access;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Parts", Namespace = "", IsNullable = false)]
    public class Parts_T
    {
        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Call", typeof(Call_T))]
        [XmlElement("Part", typeof(Part_T))]
        public object[] Items { get; set; }
    }
}
