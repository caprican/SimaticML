using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    [Serializable]
    //[XmlRoot("IntegerAttribute", Namespace = "", IsNullable = false)]
    public class IntegerAttribute_T : AttributeBase
    {
        public IntegerAttribute_T()
        {
            Informative = false;
            SystemDefined = true;
        }

        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Exported only with ReadOnly option, ignored during import.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }

        /// <summary>
        /// An attribute of attribute, denotes if it is defined by a user or the system itself. In V14, if exists it is always true.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(true)]
        public bool SystemDefined { get; set; }

        [XmlText(DataType = "integer")]
        public string Value { get; set; }

        /// <remarks>Add on v2</remarks>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
