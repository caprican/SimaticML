using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PredefinedVariable", IsNullable = false)]
    public class PredefinedVariable_T : Object_G
    {
        [XmlAttribute]
        public PredefinedVariable_TE Name { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<PredefinedVariable_TE>(reader.GetAttribute("Name"), out var name);
            Name = name;

            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
