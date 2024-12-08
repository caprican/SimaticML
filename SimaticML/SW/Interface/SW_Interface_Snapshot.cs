using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Interface
{
    [Serializable]
    //[XmlRoot("SnapshotValues", Namespace = "", IsNullable = false)]
    public class SnapshotValues_T
    {
        [XmlElement("Value")]
        public Value_T[] Value { get; set; }
    }

    [Serializable]
    //[XmlRoot("Value", Namespace = "", IsNullable = false)]
    public class Value_T
    {
        [XmlAttribute]
        public string Path { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
