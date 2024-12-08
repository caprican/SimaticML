using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("StepName", Namespace = "", IsNullable = false)]
    public class StepName_T
    {
        /// <summary>
        /// For translated step names
        /// </summary>
        [XmlElement("MultiLanguageText")]
        public MultiLanguageText_T[] MultiLanguageText { get; set; }
    }
}
