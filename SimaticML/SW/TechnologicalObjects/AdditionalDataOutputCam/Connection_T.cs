using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataOutputCam
{
    /// <summary>
    /// Describes a connection of a TO interface.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/OutputCam/v1")]
    public class Connection_T
    {
        /// <summary>
        /// Specifies the Interface of the TO that is connected.
        /// </summary>
        [XmlAttribute]
        public Interface_TE Interface { get; set; }

        /// <summary>
        /// Output bit address.
        /// </summary>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string OutputAddress { get; set; }

        /// <summary>
        /// Name of a connected tag.
        /// </summary>
        [XmlAttribute]
        public string OutputTag { get; set; }
    }
}
