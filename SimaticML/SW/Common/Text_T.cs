using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    [Serializable]
    //[XmlRoot("Text", Namespace = "", IsNullable = false)]
    public class Text_T
    {
        [XmlText]
        public string Value { get; set; }

        /// <remarks>Add on v2</remarks>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

}
