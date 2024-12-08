using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class TrigonometricValues
    {
        public TrigonometricValues()
        {
            Amplitude = (float)1F;
            StartPhase = (float)0F;
            EndPhase = (float)6.283185F;
            Frequency = (float)1F;
            PeriodLength = (float)1F;
        }

        [XmlAttribute]
        [DefaultValue(typeof(float), "1")]
        public float Amplitude { get; set; }

        // two of four are required and at least StartPhase or EndPhase is required

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float StartPhase { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "6.283185")]
        public float EndPhase { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "1")]
        public float Frequency { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "1")]
        public float PeriodLength { get; set; }
    }
}
