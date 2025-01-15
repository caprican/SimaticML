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
    [XmlRoot("Labels", Namespace = "", IsNullable = false)]
    public class Labels_T
    {
        [XmlElement("LabelDeclaration")]
        public CompileUnitCommon.LabelDeclaration_T[] LabelDeclaration { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Labels", Namespace = "", IsNullable = false)]
    public class Labels_T_v2 : Labels_T
    {
        [XmlElement("LabelDeclaration")]
        public new CompileUnitCommon.LabelDeclaration_T_v2[] LabelDeclaration { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Labels", Namespace = "", IsNullable = false)]
    public class Labels_T_v4 : Labels_T_v2
    {
        [XmlElement("LabelDeclaration")]
        public new CompileUnitCommon.LabelDeclaration_T_v4[] LabelDeclaration { get; set; }
    }
}
