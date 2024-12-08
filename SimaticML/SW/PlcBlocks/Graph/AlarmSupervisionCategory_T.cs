using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("AlarmSupervisionCategory", Namespace = "", IsNullable = false)]
    public class AlarmSupervisionCategory_T
    {
        /// <summary>
        /// Enabler token
        /// </summary>
        public Token_T Token { get; set; }

        [XmlAttribute]
        public ushort Id { get; set; }

        [XmlAttribute]
        public ushort DisplayClass { get; set; }
    }
}
