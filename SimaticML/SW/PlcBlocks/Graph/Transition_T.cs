using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.Common;
using SimaticML.SW.PlcBlocks.LADFBD;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Transition", Namespace = "", IsNullable = false)]
    public class Transition_T
    {
        public Transition_T()
        {
            IsMissing = false;
        }

        public Comment Comment { get; set; }

        public FlgNet_T FlgNet { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsMissing { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public ProgrammingLanguage_TE? ProgrammingLanguage { get; set; }

        [XmlArrayItem("MultiLanguageText", IsNullable = false)]
        public MultiLanguageText_T[] TransitionName { get; set; }
    }
}
