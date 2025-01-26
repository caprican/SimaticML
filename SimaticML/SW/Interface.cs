using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML.SW
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    public class Interface_T : IXmlSerializable
    {
        [XmlArray("Sections")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Sections_T), Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v2")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Sections_T_v3), Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v3")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Sections_T_v4), Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
        [XmlArrayItem("Section", Type = typeof(InterfaceSections.Sections_T_v5), Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v5")]
        public InterfaceSections.Sections_T[] Sections { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<InterfaceSections.Sections_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.NamespaceURI)
                    {
                        case "http://www.siemens.com/automation/Openness/SW/Interface/v2":
                            var section = new InterfaceSections.Sections_T();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/Interface/v3":
                            var section_v3 = new InterfaceSections.Sections_T_v3();
                            section_v3.ReadXml(reader);
                            sections.Add(section_v3);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/Interface/v4":
                            var section_v4 = new InterfaceSections.Sections_T_v4();
                            section_v4.ReadXml(reader);
                            sections.Add(section_v4);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/Interface/v5":
                            var section_v5 = new InterfaceSections.Sections_T_v5();
                            section_v5.ReadXml(reader);                            
                            sections.Add(section_v5);
                            break;
                    }
                }
                if(sections.Count > 0) Sections = sections.ToArray();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            
        }
    }
}
