﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.Tags
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [DebuggerDisplay("{CompositionName} ID={ID}")]
    public class PlcUserConstant : Object_T, IXmlSerializable
    {
        [XmlElement("AttributeList", typeof(AttributesPlcConstant))]
        public AttributesPlcConstant Attributes { get; set; }

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
                var attributes = new AttributesPlcConstant();
                attributes.ReadXml(reader);
                Attributes = attributes;
            }

            reader.MoveToContent();
            if (reader.Name == "ObjectList")
            {
                reader.Read();

                var items = new List<Object_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "MultilingualText":
                            var text = new MultilingualText_T();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "MultilingualTextItem":
                            var textItem = new MultilingualTextItem_T();
                            textItem.ReadXml(reader);
                            items.Add(textItem);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }

                if (items.Count > 0) Items = items.ToArray();
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class AttributesPlcConstant : IXmlSerializable
    {
        public string Name { get; set; }
        public bool NameSpecified { get; set; }

        public string DataTypeName { get; set; }
        public string Value {  get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            reader.Read();

            while (reader.MoveToContent() == XmlNodeType.Element)
            {
                switch (reader.Name)
                {
                    case nameof(Name):
                        Name = reader.ReadInnerXml();
                        NameSpecified = true;
                        break;

                    case nameof(DataTypeName):
                        DataTypeName = reader.ReadInnerXml();
                        break;

                    case nameof(Value):
                        Value = reader.ReadInnerXml();
                        break;

                    default:
                        reader.Skip();
                        break;
                }

            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
