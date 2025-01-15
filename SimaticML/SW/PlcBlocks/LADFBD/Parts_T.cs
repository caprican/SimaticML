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
    [XmlRoot("Parts", Namespace = "", IsNullable = false)]
    public class Parts_T
    {
        [XmlElement("Access", typeof(Access.Access_T))]
        [XmlElement("Call", typeof(Call_T))]
        [XmlElement("Part", typeof(Part_T))]
        public object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", Namespace = "", IsNullable = false)]
    public class Parts_T_v2 : Parts_T
    {
        [XmlElement("Access", typeof(Access.Access_T_v2))]
        [XmlElement("Call", typeof(Call_T_v2))]
        [XmlElement("Part", typeof(Part_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", Namespace = "", IsNullable = false)]
    public class Parts_T_v3 : Parts_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T_v3))]
        [XmlElement("Call", typeof(Call_T_v3))]
        [XmlElement("Part", typeof(Part_T_v3))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", Namespace = "", IsNullable = false)]
    public class Parts_T_v4 : Parts_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T_v4))]
        [XmlElement("Call", typeof(Call_T_v4))]
        [XmlElement("Part", typeof(Part_T_v4))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", Namespace = "", IsNullable = false)]
    public class Parts_T_v5 : Parts_T_v4
    {
        [XmlElement("Access", typeof(Access.Access_T_v5))]
        [XmlElement("Call", typeof(Call_T_v5))]
        [XmlElement("Part", typeof(Part_T_v5))]
        public new object[] Items { get; set; }
    }
}
