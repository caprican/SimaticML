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
    [DebuggerDisplay("{Value}")]
    [XmlRoot("Text", IsNullable = false)]
    public class Text_T : Object_G
    {
        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
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
    [DebuggerDisplay("{Value}")]
    [XmlRoot("Text", IsNullable = false)]
    public class Text_T_v2 : Text_T
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
