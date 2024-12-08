using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("AlarmSupervisionCategories", Namespace = "", IsNullable = false)]
    public class AlarmSupervisionCategories_T
    {
        [XmlElement("AlarmSupervisionCategory")]
        public AlarmSupervisionCategory_T[] AlarmSupervisionCategory { get; set; }
    }
}
