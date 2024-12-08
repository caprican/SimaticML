using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataMeasuringInput
{
    /// <summary>
    /// Describes additional data, such as Connections, for MeasuringInput TOs.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/MeasuringInput/v1")]
    [XmlRoot("AdditionalData", Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/MeasuringInput/v1", IsNullable = false)]
    public class AdditionalData_T
    {
        public Connection_T Connection { get; set; }
    }
}
