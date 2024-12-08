using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("PredefinedVariable", Namespace = "", IsNullable = false)]
    public class PredefinedVariable_T
    {
        [XmlAttribute]
        public PredefinedVariable_TE Name { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
    }
}
