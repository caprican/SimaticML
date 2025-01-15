using System;
using System.ComponentModel;
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
    [XmlRoot("Step", Namespace = "", IsNullable = false)]
    public class Step_T
    {
        public Step_T()
        {
            IsMissing = false;
            Init = false;
        }

        public Common.Comment_T Comment { get; set; }

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
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", Namespace = "", IsNullable = false)]
    public class Step_T_v2 : Step_T
    {
        public new Common.Comment_T_v2 Comment { get; set; }

        public new Supervisions_T_v2 Supervisions { get; set; }

        [XmlArrayItem("MultiLanguageText", IsNullable = false)]
        public Common.MultiLanguageText_T_v2[] StepName { get; set; }

        public new Actions_T_v2 Actions { get; set; }

        public new Interlocks_T_v2 Interlocks { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", Namespace = "", IsNullable = false)]
    public class Step_T_v4 : Step_T_v2
    {
        public new Supervisions_T_v4 Supervisions { get; set; }

        public new Interlocks_T_v4 Interlocks { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", Namespace = "", IsNullable = false)]
    public class Step_T_v5 : Step_T_v4
    {
        public new Supervisions_T_v5 Supervisions { get; set; }

        public new Actions_T_v5 Actions { get; set; }

        public new Interlocks_T_v5 Interlocks { get; set; }

    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", Namespace = "", IsNullable = false)]
    public class Step_T_v6 : Step_T_v5
    {
        public new Supervisions_T_v6 Supervisions { get; set; }

        public new Interlocks_T_v6 Interlocks { get; set; }

    }
}
