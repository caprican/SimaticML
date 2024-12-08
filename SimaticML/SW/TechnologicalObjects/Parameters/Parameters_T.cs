using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.Parameters
{
    /// <summary>
    /// Describes a list of parameters.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Parameters/v1")]
    [XmlRoot("Parameters", Namespace = "http://www.siemens.com/automation/Openness/SW/Parameters/v1", IsNullable = false)]
    public class Parameters_T
    {
        [XmlElement("Parameter")]
        public Parameter_T[] Parameter { get; set; }

        [XmlAnyElement]
        public System.Xml.XmlElement[] Any { get; set; }
    }
}
