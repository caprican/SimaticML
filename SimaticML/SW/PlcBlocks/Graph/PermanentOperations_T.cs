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
    [XmlRoot("PostOperations", Namespace = "", IsNullable = false)]
    public class PermanentOperations_T
    {
        public Common.Comment_T Title { get; set; }

        public Common.Comment_T Comment { get; set; }

        [XmlElement("PermanentOperation")]
        public PermanentOperation_T[] PermanentOperation { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", Namespace = "", IsNullable = false)]
    public class PermanentOperations_T_v2 : PermanentOperations_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v2[] PermanentOperation { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", Namespace = "", IsNullable = false)]
    public class PermanentOperations_T_v4 : PermanentOperations_T_v2
    {
        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v4[] PermanentOperation { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", Namespace = "", IsNullable = false)]
    public class PermanentOperations_T_v5 : PermanentOperations_T_v4
    {
        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v5[] PermanentOperation { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", Namespace = "", IsNullable = false)]
    public class PermanentOperations_T_v6 : PermanentOperations_T_v5
    {
        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v6[] PermanentOperation { get; set; }
    }
}
