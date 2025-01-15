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
    [XmlRoot("Action", Namespace = "", IsNullable = false)]
    public class Action_T
    {
        [XmlElement("Access", typeof(Access.Access_T))]
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        [XmlElement("Token", typeof(Common.Token_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public Event_TE? Event { get; set; }
        [XmlIgnore]
        public bool EventSpecified { get; set; }

        [XmlAttribute]
        public bool Interlock { get; set; }
        [XmlIgnore]
        public bool InterlockSpecified { get; set; }

        [XmlAttribute]
        public Qualifier_TE? Qualifier { get; set; }
        [XmlIgnore]
        public bool QualifierSpecified { get; set; }
    }

    /// <remarks>
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Action", Namespace = "", IsNullable = false)]
    public class Action_T_v2 : Action_T
    {
        [XmlElement("Access", typeof(Access.Access_T))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Action", Namespace = "", IsNullable = false)]
    public class Action_T_v5 : Action_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }
}
