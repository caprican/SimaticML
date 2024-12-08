using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;
using SimaticML.SW.PlcBlocks.LADFBD;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Interlock", Namespace = "", IsNullable = false)]
    public class AlarmSupportingLanguageModule_T
    {
        public Comment_T Title { get; set; }

        public AlarmText_T AlarmText { get; set; }

        public FlgNet_T FlgNet { get; set; }

        [XmlAttribute]
        public ProgrammingLanguage_TE? ProgrammingLanguage { get; set; }
    }
}
