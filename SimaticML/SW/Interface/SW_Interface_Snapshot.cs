using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Interface
{
    [Serializable]
    [XmlRoot("SnapshotValues", IsNullable = false)]
    public class SnapshotValues_T : Object_G
    {
        [XmlElement("Value")]
        public Value_T[] Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var values = new List<Value_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Value":
                            var value = new Value_T();
                            value.ReadXml(reader);
                            values.Add(value);
                            break;
                    }
                }
                if (values.Count > 0) Value = values.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }

    [Serializable]
    [XmlRoot("Value", IsNullable = false)]
    public class Value_T : Object_G
    {
        [XmlAttribute]
        public string Path { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Path = reader.GetAttribute("Path");
            Type = reader.GetAttribute("Type");

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
