using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataAxis
{
    /// <summary>
    /// Describes additional data, such as Connections, for Axis and ExternalEncoder TOs.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Axis/v1")]
    [XmlRoot("AdditionalData", Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Axis/v1", IsNullable = false)]
    public class AdditionalData_T
    {
        [XmlElement("Connection")]
        public Connection_T[] Connection { get; set; }

        public SynchronousAxisMasterValues_T SynchronousAxisMasterValues { get; set; }
    }
}
