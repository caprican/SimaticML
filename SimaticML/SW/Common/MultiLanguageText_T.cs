using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    public interface IMultiLanguageText_T
    {
        string Lang { get; set; }

        string Value { get; set; }
    }

    public interface IMultiLanguageText_T_v2 : IMultiLanguageText_T
    {
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{(Lang)}{Value}")]
    [XmlRoot("MultiLanguageText", IsNullable = false)]
    public class MultiLanguageText_T : Object_G, IMultiLanguageText_T
    {
        [XmlAttribute("Lang")]
        public string Lang { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Lang):
                        Lang = reader.ReadContentAsString();
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
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{(Lang)}{Value}")]
    [XmlRoot("MultiLanguageText", IsNullable = false)]
    public class MultiLanguageText_T_v2 : MultiLanguageText_T, IMultiLanguageText_T_v2
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch(reader.LocalName)
                {
                    case nameof(Lang):
                        Lang = reader.ReadContentAsString();
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
