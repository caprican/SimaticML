using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : SW_Common
    /// </remarks>
    [Serializable]
    [XmlRoot("Token", Namespace = "", IsNullable = false)]
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

    /// <remarks>
    /// Schema : SW_Common_v2
    ///          SW_Common_v3
    /// </remarks>
    [Serializable]
    [XmlRoot("Token", Namespace = "", IsNullable = false)]
    public class Token_T_v2 : Token_T
    {
        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces at the start.
        /// This is informative.
        /// </summary>
        public new IntegerAttribute_T_v2 IntegerAttribute { get; set; }
    }
}
