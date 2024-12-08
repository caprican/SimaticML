using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataKinematics
{
    /// <summary>
    /// Describes additional data, such as connected axes, for Kinematics TOs.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Kinematics/v1")]
    [XmlRoot("AdditionalData", Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Kinematics/v1", IsNullable = false)]
    public class AdditionalData_T
    {
        [XmlElement("KinematicsAxis")]
        public TechnologicalObjectReferenceWithIndex_T[] KinematicsAxis { get; set; }

        public ConveyorTrackingLeadingValues_T ConveyorTrackingLeadingValues { get; set; }
    }
}
