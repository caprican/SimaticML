using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class DefinitionRange
    {
        [XmlAttribute]
        public float Start { get; set; }
        [XmlIgnore]
        public bool StartSpecified { get; set; }

        [XmlAttribute]
        public float End { get; set; }
        [XmlIgnore]
        public bool EndSpecified { get; set; }
    }
}
