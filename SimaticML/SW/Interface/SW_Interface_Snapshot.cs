using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Interface
{
    public interface ISnapshotValues
    {
        IValue[] Values { get; set; }
    }

    [Serializable]
    [XmlRoot("SnapshotValues", IsNullable = false)]
    public class SnapshotValues_T : Object_G, ISnapshotValues
    {
        [XmlElement("Value")]
        public IValue[] Values { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var values = new List<IValue>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Value":
                            var value = new Value_T();
                            value.ReadXml(reader);
                            values.Add(value);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (values.Count > 0) Values = values.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public interface IValue
    {
        string Path { get; set; }
        string Type { get; set; }
        string Value { get; set; }
    }

    [Serializable]
    [XmlRoot("Value", IsNullable = false)]
    public class Value_T : Object_G, IValue
    {
        [XmlAttribute]
        public string Path { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Path):
                        Path = reader.ReadContentAsString();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
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
