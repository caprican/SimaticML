using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", Namespace = "", IsNullable = false)]
    public class Call_T
    {
        public Access.CallInfo_T CallInfo { get; set; }

        [XmlElement("TemplateValue")]
        public Access.TemplateValue_T[] TemplateValue { get; set; }

        [XmlElement("AutomaticTyped")]
        public AutomaticTyped_T[] AutomaticTyped { get; set; }

        [XmlElement("Invisible")]
        public Invisible_T[] Invisible { get; set; }

        [XmlElement("Negated")]
        public Neg_T[] Negated { get; set; }

        public Common.Comment_T Comment { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", Namespace = "", IsNullable = false)]
    public class Call_T_v2 : Call_T
    {
        public new Access.CallInfo_T_v2 CallInfo { get; set; }

        [XmlElement("TemplateValue")]
        public new Access.TemplateValue_T_v2[] TemplateValue { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", Namespace = "", IsNullable = false)]
    public class Call_T_v3 : Call_T_v2
    {
        public new Access.CallInfo_T_v3 CallInfo { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", Namespace = "", IsNullable = false)]
    public class Call_T_v4 : Call_T_v3
    {
        public new Access.CallInfo_T_v4 CallInfo { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", Namespace = "", IsNullable = false)]
    public class Call_T_v5 : Call_T_v4
    {
        public new Access.CallInfo_T_v5 CallInfo { get; set; }
    }
}
