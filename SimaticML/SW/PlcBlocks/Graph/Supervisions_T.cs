using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Supervisions", Namespace = "", IsNullable = false)]
    public class Supervisions_T
    {
        public AlarmSupportingLanguageModule_T Supervision { get; set; }
    }
}
