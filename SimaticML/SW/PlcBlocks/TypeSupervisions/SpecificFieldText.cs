using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class SpecificFieldText : Object_G
    {
        [XmlElement("MultiLanguageText")]
        public Common.MultiLanguageText_T[] MultiLanguageText { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.MultiLanguageText_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "MultiLanguageText":
                            var value = new Common.MultiLanguageText_T();
                            value.ReadXml(reader);
                            texts.Add(value);
                            break;
                    }
                }
                if (texts.Count > 0) MultiLanguageText = texts.ToArray();
            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class SpecificFieldText_v2 : SpecificFieldText
    {
        [XmlElement("MultiLanguageText")]
        public new Common.MultiLanguageText_T_v2[] MultiLanguageText { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.MultiLanguageText_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "MultiLanguageText":
                            var value = new Common.MultiLanguageText_T_v2();
                            value.ReadXml(reader);
                            texts.Add(value);
                            break;
                    }
                }
                if (texts.Count > 0) MultiLanguageText = texts.ToArray();
            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
