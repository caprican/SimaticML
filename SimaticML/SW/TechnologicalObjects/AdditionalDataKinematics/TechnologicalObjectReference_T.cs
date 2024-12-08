using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataKinematics
{
    /// <summary>
    /// Describes a reference to a Technological Object.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Kinematics/v1")]
    public class TechnologicalObjectReference_T
    {
        /// <summary>
        /// Specifies the name of the referenced Technological Object.
        /// </summary>
        [XmlAttribute]
        public string Ref { get; set; }

        /// <summary>
        /// Specifies the type of the referenced Technological Object.
        /// </summary>
        [XmlAttribute]
        public string Type { get; set; }
    }
}
