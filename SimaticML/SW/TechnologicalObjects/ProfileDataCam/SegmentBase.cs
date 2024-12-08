using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class SegmentBase
    {
        [XmlAttribute]
        public float StartX { get; set; }

        [XmlAttribute]
        public float EndX { get; set; }
    }
}
