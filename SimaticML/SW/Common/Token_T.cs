using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    [Serializable]
    //[XmlRoot("Token", Namespace = "", IsNullable = false)]
    public class Token_T
    {
        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces at the start.
        /// This is informative.
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public string Text { get; set; }
    }
}
