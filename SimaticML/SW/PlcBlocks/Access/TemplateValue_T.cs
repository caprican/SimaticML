using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface ITemplateValue
    {
        string Name { get; set; }
        TemplateType_TE Type { get; set; }
        string Value { get; set; }
    }

    public interface ITemplateValue_v2 : ITemplateValue
    {
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access (SW.Common)</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("TemplateValue", IsNullable = false)]
    public class TemplateValue_T : Object_G, ITemplateValue
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public TemplateType_TE Type { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Type):
                        Enum.TryParse<TemplateType_TE>(reader.ReadContentAsString(), out var type);
                        Type = type;
                        break;

                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadInnerXml();
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
    public class TemplateValue_T_v2 : TemplateValue_T, ITemplateValue_v2
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Type):
                        Enum.TryParse<TemplateType_TE>(reader.ReadContentAsString(), out var type);
                        Type = type;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadInnerXml();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
