using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : SW_Common
    /// </remarks>
    [Serializable]
    [XmlRoot("LineComment", Namespace = "", IsNullable = false)]
    public class LineComment_T : Comment_G
    {
        public LineComment_T()
        {
            Inserted = false;
        }

        /// <summary>
        /// For NumBLs in STL. NumBLs is the count of the blank spaces before the actual text in the LineComment.
        /// This is informative.
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }


        /// <summary>
        /// Denotes if the comment is at the end of the line (using //) or inside the line (using /* */)
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Inserted { get; set; }

        /// <summary>
        /// the value of the comment
        /// </summary>
        [XmlElement("Text", typeof(Text_T))]
        public object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_Common_v2
    /// </remarks>
    [Serializable]
    [XmlRoot("LineComment", Namespace = "", IsNullable = false)]
    public class LineComment_T_v2 : LineComment_T
    {
        /// <summary>
        /// For NumBLs in STL. NumBLs is the count of the blank spaces before the actual text in the LineComment.
        /// This is informative.
        /// </summary>
        public new IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        /// <summary>
        /// the value of the comment
        /// </summary>
        [XmlElement("Text", typeof(Text_T_v2))]
        public new object[] Items { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool NoClosingBracket { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : SW_Common_v3
    /// </remarks>
    [Serializable]
    [XmlRoot("LineComment", Namespace = "", IsNullable = false)]
    public class LineComment_T_v3 : LineComment_T_v2
    {
        /// <summary>
        /// the value of the comment
        /// </summary>
        [XmlElement("Comment", typeof(Comment_T_v2))]
        [XmlElement("Text", typeof(Text_T_v2))]
        public new object[] Items { get; set; }
    }
}
