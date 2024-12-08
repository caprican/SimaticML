using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("AlarmInterlockCategory", Namespace = "", IsNullable = false)]
    public class AlarmCategory_T
    {
        [XmlAttribute]
        public ushort Id { get; set; }
    }
}
