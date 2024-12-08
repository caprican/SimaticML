using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("AlarmsSettings", Namespace = "", IsNullable = false)]
    public class AlarmsSettings_T
    {
        public AlarmSupervisionCategories_T AlarmSupervisionCategories { get; set; }

        public AlarmCategory_T AlarmInterlockCategory { get; set; }

        public AlarmCategory_T AlarmWarningCategory { get; set; }

        /// <summary>
        /// Added on V4
        /// </summary>
        public AlarmSubcategory_T AlarmSubcategory1Interlock { get; set; }

        public AlarmSubcategory_T AlarmSubcategory2Interlock { get; set; }

        public AlarmCategory_T AlarmCategorySupervision { get; set; }

        public AlarmSubcategory_T AlarmSubcategory1Supervision { get; set; }

        public AlarmSubcategory_T AlarmSubcategory2Supervision { get; set; }

        public AlarmSubcategory_T AlarmSubcategory1Warning { get; set; }

        public AlarmSubcategory_T AlarmSubcategory2Warning { get; set; }
    }

}
