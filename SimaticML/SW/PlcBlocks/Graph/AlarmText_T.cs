using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("AlarmText", Namespace = "", IsNullable = false)]
    public class AlarmText_T
    {
        /// <summary>
        /// Temporary change for enable of empty alarm text because of the graph alarm handling reconstruction.
        /// </summary>
        [XmlElement("MultiLanguageText")]
        public MultiLanguageText_T[] MultiLanguageText { get; set; }
    }
}
