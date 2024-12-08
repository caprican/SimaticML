using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    ///<remarks>Add on v2</remarks>
    [Serializable]
    [XmlRoot("TransitionName", Namespace = "", IsNullable = false)]
    public class TransitionName_T
    {
        /// <summary>
        /// For translated transiton names
        /// </summary>

        [XmlElement("MultiLanguageText")]
        public MultiLanguageText_T[] MultiLanguageText { get; set; }
    }
}
