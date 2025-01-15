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
    [XmlRoot("FlgNet", Namespace = "", IsNullable = false)]
    public class FlgNet_T
    {
        public Labels_T Labels { get; set; }

        [XmlArrayItem("Access", typeof(Access.Access_T), IsNullable = false)]
        [XmlArrayItem("Call", typeof(Call_T), IsNullable = false)]
        [XmlArrayItem("Part", typeof(Part_T), IsNullable = false)]
        public object[] Parts { get; set; }

        public Wires_T Wires { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", Namespace = "", IsNullable = false)]
    public class FlgNet_T_v2 : FlgNet_T
    {
        public new Labels_T_v2 Labels { get; set; }

        [XmlArrayItem("Access", typeof(Access.Access_T_v2), IsNullable = false)]
        [XmlArrayItem("Call", typeof(Call_T_v2), IsNullable = false)]
        [XmlArrayItem("Part", typeof(Part_T_v2), IsNullable = false)]
        public new object[] Parts { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", Namespace = "", IsNullable = false)]
    public class FlgNet_T_v3 : FlgNet_T_v2
    {
        [XmlArrayItem("Access", typeof(Access.Access_T_v3), IsNullable = false)]
        [XmlArrayItem("Call", typeof(Call_T_v3), IsNullable = false)]
        [XmlArrayItem("Part", typeof(Part_T_v3), IsNullable = false)]
        public new object[] Parts { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", Namespace = "", IsNullable = false)]
    public class FlgNet_T_v4 : FlgNet_T_v3
    {
        public new Labels_T_v4 Labels { get; set; }

        [XmlArrayItem("Access", typeof(Access.Access_T_v4), IsNullable = false)]
        [XmlArrayItem("Call", typeof(Call_T_v4), IsNullable = false)]
        [XmlArrayItem("Part", typeof(Part_T_v4), IsNullable = false)]
        public new object[] Parts { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", Namespace = "", IsNullable = false)]
    public class FlgNet_T_v5 : FlgNet_T_v4
    {
        [XmlArrayItem("Access", typeof(Access.Access_T_v5), IsNullable = false)]
        [XmlArrayItem("Call", typeof(Call_T_v5), IsNullable = false)]
        [XmlArrayItem("Part", typeof(Part_T_v5), IsNullable = false)]
        public new object[] Parts { get; set; }
    }
}
