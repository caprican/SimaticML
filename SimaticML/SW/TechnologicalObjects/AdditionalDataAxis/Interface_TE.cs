using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataAxis
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Axis/v1")]
    public enum Interface_TE
    {
        Actor,
        Sensor,

        [XmlEnum("Sensor[1]")]
        Sensor1,
        [XmlEnum("Sensor[2]")]
        Sensor2,
        [XmlEnum("Sensor[3]")]
        Sensor3,
        [XmlEnum("Sensor[4]")]
        Sensor4,

        Torque,
        OutputCam,
        MeasuringInput
    }
}
