using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML.SW.WatchAndForceTables
{
    [Serializable]
    
    [DebuggerDisplay("{CompositionName} ID={ID}")]
    public class PlcWatchTableEntry : Object_T, IXmlSerializable
    {
        [XmlElement("AttributeList", typeof(AttributesPlcWatchEntry))]
        public AttributesPlcWatchEntry Attributes { get; set; }

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
                var attributes = new AttributesPlcWatchEntry();
                attributes.ReadXml(reader);
                Attributes = attributes;
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

    public class AttributesPlcWatchEntry : IXmlSerializable
    {
        public string Name { get; set; }
        public bool NameSpecified { get; set; }

        public string DisplayFormat { get; set; }

        public string ModifyValue { get; set; }

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

                    case nameof(DisplayFormat):
                        DisplayFormat = reader.ReadInnerXml();
                        break;

                    case nameof(ModifyValue):
                        ModifyValue = reader.ReadInnerXml();
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
