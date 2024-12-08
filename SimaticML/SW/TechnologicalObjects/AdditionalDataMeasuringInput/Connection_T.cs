using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataMeasuringInput
{
    /// <summary>
    /// Describes a connection of a TO interface.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/MeasuringInput/v1")]
    public class Connection_T
    {
        /// <summary>
        /// Specifies the Interface of the TO that is connected.
        /// </summary>
        [XmlAttribute]
        public Interface_TE Interface { get; set; }

        /// <summary>
        /// Input bit address.
        /// </summary>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string InputAddress { get; set; }
    }
}
