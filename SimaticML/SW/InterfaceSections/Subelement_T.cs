using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.InterfaceSections
{
    [Serializable]
    //[XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T
    {
        [XmlElement("Comment", typeof(Comment))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Path { get; set; }
    }
}
