using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access (SW.Common)</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("TemplateValue", IsNullable = false)]
    public class TemplateValue_T : Object_G
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public TemplateType_TE Type { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<TemplateType_TE>(reader.GetAttribute("Type"), out var type);
            Type = type;

            Name = reader.GetAttribute("Name");

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

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
    [XmlRoot("TemplateValue", IsNullable = false)]
    public class TemplateValue_T_v2 : TemplateValue_T
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<TemplateType_TE>(reader.GetAttribute("Type"), out var type);
            Type = type;

            Name = reader.GetAttribute("Name");

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
