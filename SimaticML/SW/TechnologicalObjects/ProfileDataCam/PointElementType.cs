using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    //Due to multiple usage, we place that element type explicitly here
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class PointElementType
    {
        [XmlAttribute]
        public float X { get; set; }

        [XmlAttribute]
        public float Y { get; set; }

        [XmlAttribute]
        public float Velocity { get; set; }
        [XmlIgnore]
        public bool VelocitySpecified { get; set; }

        [XmlAttribute]
        public float Acceleration { get; set; }
        [XmlIgnore]
        public bool AccelerationSpecified { get; set; }

        [XmlAttribute]
        public float Jerk { get; set; }
        [XmlIgnore]
        public bool JerkSpecified { get; set; }
    }
}
