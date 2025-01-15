﻿using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmsSettings", Namespace = "", IsNullable = false)]
    public class AlarmsSettings_T
    {
        public AlarmSupervisionCategories_T AlarmSupervisionCategories { get; set; }

        public AlarmCategory_T AlarmInterlockCategory { get; set; }

        public AlarmCategory_T AlarmWarningCategory { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmsSettings", Namespace = "", IsNullable = false)]
    public class AlarmsSettings_T_v2 : AlarmsSettings_T
    {
        public new AlarmSupervisionCategories_T_v2 AlarmSupervisionCategories { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmsSettings", Namespace = "", IsNullable = false)]
    public class AlarmsSettings_T_v4 : AlarmsSettings_T_v2
    {
        public AlarmSubcategory_T AlarmSubcategory1Interlock { get; set; }

        public AlarmSubcategory_T AlarmSubcategory2Interlock { get; set; }

        public AlarmSubcategory_T AlarmSubcategory1Supervision { get; set; }

        public AlarmSubcategory_T AlarmSubcategory2Supervision { get; set; }

        public AlarmSubcategory_T AlarmSubcategory1Warning { get; set; }

        public AlarmSubcategory_T AlarmSubcategory2Warning { get; set; }
    }
}
