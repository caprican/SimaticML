using System;
using System.Xml.Serialization;

using SimaticML.SW.PlcBlocks.Access;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable()]
    [XmlRoot("FlgNet", Namespace = "", IsNullable = false)]
    public class FlgNet_T
    {
        public Labels_T Labels { get; set; }

        [XmlArrayItem("Access", typeof(Access_T), IsNullable = false)]
        [XmlArrayItem("Call", typeof(Call_T), IsNullable = false)]
        [XmlArrayItem("Part", typeof(Part_T), IsNullable = false)]
        public object[] Parts { get; set; }

        public Wires_T Wires { get; set; }
    }
}
