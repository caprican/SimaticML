using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Lang} = {Value}")]
    [XmlRoot("MultiLanguageText", IsNullable = false)]
    public class MultiLanguageText_T : Object_G
    {
        [XmlAttribute]
        public string Lang { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Lang = reader.GetAttribute("Lang");

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {

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
    [DebuggerDisplay("{Lang} = {Value}")]
    [XmlRoot("MultiLanguageText", IsNullable = false)]
    public class MultiLanguageText_T_v2 : MultiLanguageText_T
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Lang = reader.GetAttribute("Lang");

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if(UIdSpecified) UId = uId;

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {

        }
    }
}
