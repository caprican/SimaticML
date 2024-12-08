using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.Parameters
{
    /// <summary>
    /// Describes a single parameter, having Name and Value. If the Value is missing, the default value of the Parameter is used.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Parameters/v1")]
    public class Parameter_T
    {
        /// <summary>
        /// Name of the Parameter
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Value of the Parameter
        /// </summary>
        [XmlAttribute]
        public string Value { get; set; }
    }
}
