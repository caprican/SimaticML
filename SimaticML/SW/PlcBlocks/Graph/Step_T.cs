using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Step", Namespace = "", IsNullable = false)]
    public class Step_T
    {
        public Step_T()
        {
            IsMissing = false;
            Init = false;
        }

        public Comment Comment { get; set; }

        public Actions_T Actions { get; set; }

        public Supervisions_T Supervisions { get; set; }

        public Interlocks_T Interlocks { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsMissing { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Init { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string MaximumStepTime { get; set; }

        [XmlAttribute]
        public string WarningTime { get; set; }

        [XmlArrayItem("MultiLanguageText", IsNullable = false)]
        public MultiLanguageText_T[] StepName { get; set; }
    }
}
