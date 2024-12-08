using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    [Serializable]
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

        /// <remarks> Add on V2</remarks>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

}
