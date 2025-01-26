using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    [DebuggerDisplay("{Culture} = {Text}")]
    public class MultilingualTextItem_T : Object_T, IXmlSerializable
    {
        public string Culture { get; set; }
        public string Text { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            ID = reader.GetAttribute("ID");
            CompositionName = reader.GetAttribute("CompositionName");
            CompositionNameSpecified = CompositionName != null;

            reader.Read();

            if (!reader.IsEmptyElement)
            {
                reader.Read();
                var items = new List<Object_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            reader.Read();
                            while (reader.MoveToContent() == XmlNodeType.Element)
                            {
                                switch (reader.Name)
                                {
                                    case "Culture":
                                        Culture = reader.ReadInnerXml();
                                        break;
                                    case "Text":
                                        Text = reader.ReadInnerXml();
                                        break;
                                    default:
                                        reader.Skip();
                                        break;
                                }
                            }
                            reader.ReadEndElement();
                            break;
                        case "MultilingualText":
                            var text = new MultilingualText_T();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "SW.Blocks.CompileUnit":
                            var compileUnit = new SW.Blocks.CompileUnit();
                            items.Add(compileUnit);
                            break;
                        case "MultilingualTextItem":
                            var textItem = new MultilingualTextItem_T();
                            textItem.ReadXml(reader);
                            items.Add(textItem);
                            break;
                    }
                }

                Items = items.ToArray();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

    }
}
