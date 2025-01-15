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
    [XmlRoot("Sequence", Namespace = "", IsNullable = false)]
    public class Sequence_T
    {
        public Common.Comment_T Title { get; set; }

        public Common.Comment_T Comment { get; set; }

        public Steps_T Steps { get; set; }

        public Transitions_T Transitions { get; set; }

        public Branches_T Branches { get; set; }

        public Connections_T Connections { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", Namespace = "", IsNullable = false)]
    public class Sequence_T_v2 : Sequence_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        public new Steps_T_v2 Steps { get; set; }

        public new Transitions_T_v2 Transitions { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", Namespace = "", IsNullable = false)]
    public class Sequence_T_v4 : Sequence_T_v2
    {
        public new Transitions_T_v4 Transitions { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", Namespace = "", IsNullable = false)]
    public class Sequence_T_v5 : Sequence_T_v4
    {
        public new Steps_T_v5 Steps { get; set; }

        public new Transitions_T_v5 Transitions { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", Namespace = "", IsNullable = false)]
    public class Sequence_T_v6 : Sequence_T_v5
    {
        public new Transitions_T_v6 Transitions { get; set; }
    }
}
