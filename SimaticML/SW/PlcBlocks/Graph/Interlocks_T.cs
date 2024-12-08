using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Interlocks", Namespace = "", IsNullable = false)]
    public class Interlocks_T
    {
        public AlarmSupportingLanguageModule_T Interlock { get; set; }
    }
}
