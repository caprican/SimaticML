using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : SW_Common
    /// </remarks>
    [Serializable]
    [XmlRoot("RealAttribute", Namespace = "", IsNullable = false)]
    public class RealAttribute_T : AttributeBase
    {
        public RealAttribute_T()
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

        [XmlText]
        public string Value { get; set; }
    }

    /// <remarks>
    /// Schema : SW_Common_v2
    ///          SW_Common_v3
    /// </remarks>
    [Serializable]
    [XmlRoot("RealAttribute", Namespace = "", IsNullable = false)]
    public class RealAttribute_T_v2 : RealAttribute_T
    {
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
