using System;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class Object_T
    {
        [XmlAttribute]
        public string ID { get; set; }

        [XmlAttribute]
        public string CompositionName { get; set; }
        [XmlIgnore]
        public bool CompositionNameSpecified { get; set; }

        [XmlArrayItem("MultilingualText", typeof(MultilingualText_T))]
        //[XmlArrayItem("SW.Blocks.CompileUnit", typeof(CompileUnit))]
        [XmlArrayItem("MultilingualTextItem", typeof(MultilingualTextItem_T))]
        public Object_T[] ObjectList { get; set; }
    }
}
