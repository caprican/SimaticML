using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SpecificFieldText
    {
        [XmlElement("MultiLanguageText")]
        public Common.MultiLanguageText_T[] MultiLanguageText { get; set; }
    }
}
