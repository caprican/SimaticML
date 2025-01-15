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
    [XmlRoot("Supervisions", Namespace = "", IsNullable = false)]
    public class Supervisions_T
    {
        public AlarmSupportingLanguageModule_T Supervision { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Supervisions", Namespace = "", IsNullable = false)]
    public class Supervisions_T_v2 : Supervisions_T
    {
        public new AlarmSupportingLanguageModule_T_v2 Supervision { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Supervisions", Namespace = "", IsNullable = false)]
    public class Supervisions_T_v4 : Supervisions_T_v2
    {
        public new AlarmSupportingLanguageModule_T_v4 Supervision { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Supervisions", Namespace = "", IsNullable = false)]
    public class Supervisions_T_v5 : Supervisions_T_v4
    {
        public new AlarmSupportingLanguageModule_T_v5 Supervision { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Supervisions", Namespace = "", IsNullable = false)]
    public class Supervisions_T_v6 : Supervisions_T_v5
    {
        public new AlarmSupportingLanguageModule_T_v6 Supervision { get; set; }
    }
}
