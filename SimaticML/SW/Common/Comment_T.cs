using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Comment", Namespace = "", IsNullable = false)]
    public class Comment_T : Comment_G
    {
        public Comment_T()
        {
            Inserted = false;
            Informative = false;
        }

        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces before the actual text in the Comment.
        /// This is informative.
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("MultiLanguageText")]
        public MultiLanguageText_T[] MultiLanguageText { get; set; }

        /// <summary>
        /// Denotes if the comment is at the end of the line (using //) or inside the line (using /* */)
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Inserted { get; set; }

        /// <summary>
        /// Exported only with ReadOnly option, ignored during import.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Comment", Namespace = "", IsNullable = false)]
    public class Comment_T_v2 : Comment_T
    {
        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces before the actual text in the Comment.
        /// This is informative.
        /// </summary>
        public new IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("MultiLanguageText")]
        public new MultiLanguageText_T_v2[] MultiLanguageText { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
