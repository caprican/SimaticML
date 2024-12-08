using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public enum ElementOptimizationGoal
    {
        AsProfile,
        None,
        Velocity,
        Acceleration,
        Jerk,
        DynamicMoment
    }
}
