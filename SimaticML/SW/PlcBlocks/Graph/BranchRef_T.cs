using System;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("BranchRef", IsNullable = false)]
    public class BranchRef_T : Object_G
    {
        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public int? In { get; set; } = null;
        [XmlIgnore]
        public bool InSpecified { get; set; }

        [XmlAttribute]
        public int? Out { get; set; } = null;
        [XmlIgnore]
        public bool OutSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("Number"), out var number);
            Number = number;

            InSpecified = int.TryParse(reader.GetAttribute("In"), out var _in);
            if (InSpecified) In = _in;

            OutSpecified = int.TryParse(reader.GetAttribute("Out"), out var _out);
            if (OutSpecified) In = _out;
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
