using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class NetworkSource_T : IXmlSerializable, IEnumerable<SW.PlcBlocks.SCL.StructuredText_T>
    {
        [XmlArray("StructuredText")]
        [XmlElement(Type = typeof(SW.PlcBlocks.SCL.StructuredText_T_v2), ElementName = "StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v2")]
        [XmlElement(Type = typeof(SW.PlcBlocks.SCL.StructuredText_T_v3), ElementName = "StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
        [XmlElement(Type = typeof(SW.PlcBlocks.SCL.StructuredText_T_v4), ElementName = "StructuredText", Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v4")]
        private SW.PlcBlocks.SCL.StructuredText_T[] StructuredTexts { get; set; }
        public SW.PlcBlocks.SCL.StructuredText_T this[int key] { get => StructuredTexts[key]; set => StructuredTexts[key] = value; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var strcuturedTexts = new List<SW.PlcBlocks.SCL.StructuredText_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.NamespaceURI)
                    {
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v2":
                            var strcuturedText = new SW.PlcBlocks.SCL.StructuredText_T_v2();
                            strcuturedText.ReadXml(reader);
                            strcuturedTexts.Add(strcuturedText);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3":
                            var strcuturedText_v3 = new SW.PlcBlocks.SCL.StructuredText_T_v3();
                            strcuturedText_v3.ReadXml(reader);
                            strcuturedTexts.Add(strcuturedText_v3);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v4":
                            var strcuturedText_v4 = new SW.PlcBlocks.SCL.StructuredText_T_v4();
                            strcuturedText_v4.ReadXml(reader);
                            strcuturedTexts.Add(strcuturedText_v4);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (strcuturedTexts.Count > 0) StructuredTexts = strcuturedTexts.ToArray();
            }

            if (reader.IsStartElement())
                reader.Skip();
            else
                reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<SW.PlcBlocks.SCL.StructuredText_T> GetEnumerator()
        {
            foreach (var item in StructuredTexts)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
