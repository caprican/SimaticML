using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Labels", Namespace = "", IsNullable = false)]
    public class Labels_T
    {
        [XmlElement("LabelDeclaration")]
        public CompileUnitCommon.LabelDeclaration_T[] LabelDeclaration { get; set; }
    }
}
