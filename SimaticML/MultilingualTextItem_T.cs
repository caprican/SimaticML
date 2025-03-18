using System;
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
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ID):
                        ID = reader.ReadContentAsString();
                        break;

                    case nameof(CompositionName):
                        CompositionName = reader.ReadContentAsString();
                        CompositionNameSpecified = true;
                        break;
                }
            }

            reader.Read();
            reader.MoveToContent();
            if (reader.Name == "AttributeList")
            {
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
            }

            reader.MoveToContent();
            if (reader.Name == "ObjectList")
            {
                reader.Read();

                var items = Helpers.ObjectListHelper.Read(reader);
                if (items.Length > 0) Items = items;
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
