using System;
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
    [XmlRoot("Graph", Namespace = "", IsNullable = false)]
    public class Graph_T
    {
        public PermanentOperations_T PreOperations { get; set; }

        [XmlElement("Sequence")]
        public Sequence_T[] Sequence { get; set; }

        public PermanentOperations_T PostOperations { get; set; }

        public AlarmsSettings_T AlarmsSettings { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", Namespace = "", IsNullable = false)]
    public class Graph_T_v2 : Graph_T
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v2[] Sequence { get; set; }

        public new AlarmsSettings_T_v2 AlarmsSettings { get; set; }

    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", Namespace = "", IsNullable = false)]
    public class Graph_T_v4 : Graph_T_v2
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v4[] Sequence { get; set; }

        public new AlarmsSettings_T_v4 AlarmsSettings { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", Namespace = "", IsNullable = false)]
    public class Graph_T_v5 : Graph_T_v4
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v5[] Sequence { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", Namespace = "", IsNullable = false)]
    public class Graph_T_v6 : Graph_T_v5
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v6[] Sequence { get; set; }
    }
}
