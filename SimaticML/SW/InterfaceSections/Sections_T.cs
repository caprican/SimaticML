using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T : IXmlSerializable
    {
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T), IsNullable = false)]
        public Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Section")]
        public Section_T[] Sections { get; set; }

        [XmlAttribute]
        public string Datatype { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        public XmlSchema GetSchema() => null;

        public virtual void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            Common.BooleanAttribute_T booleanAttr = new Common.BooleanAttribute_T();
                            //booleanAttr.ReadXml(reader);
                            //attributes.Add(booleanAttr);
                            var serializer = new XmlSerializer(typeof(Common.BooleanAttribute_T));
                            booleanAttr = serializer.Deserialize(reader) as Common.BooleanAttribute_T;

                            break;
                    }
                }
                if (attributes.Count > 0) AttributeList = attributes.ToArray();

                reader.ReadEndElement();
            }
        }

        public virtual void WriteXml(XmlWriter writer)
        {
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T_v3 : Sections_T
    {
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Section")]
        public new Section_T_v3[] Sections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            Common.BooleanAttribute_T booleanAttr = new Common.BooleanAttribute_T_v2();
                            //booleanAttr.ReadXml(reader);
                            //attributes.Add(booleanAttr);
                            var serializer = new XmlSerializer(typeof(Common.BooleanAttribute_T_v2));
                            booleanAttr = serializer.Deserialize(reader) as Common.BooleanAttribute_T_v2;

                            break;
                    }
                }
                if (attributes.Count > 0) AttributeList = attributes.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T_v4 : Sections_T_v3
    {
        [XmlElement("Section")]
        public new Section_T_v4[] Sections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            Common.BooleanAttribute_T booleanAttr = new Common.BooleanAttribute_T_v2();
                            //booleanAttr.ReadXml(reader);
                            //attributes.Add(booleanAttr);
                            var serializer = new XmlSerializer(typeof(Common.BooleanAttribute_T_v2));
                            booleanAttr = serializer.Deserialize(reader) as Common.BooleanAttribute_T_v2;

                            break;
                    }
                }
                if (attributes.Count > 0) AttributeList = attributes.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T_v5 : Sections_T_v4
    {
        [XmlElement("Section")]
        public new Section_T_v5[] Sections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                var sections = new List<Section_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            var booleanAttr = new Common.BooleanAttribute_T_v2();
                            booleanAttr.ReadXml(reader);
                            attributes.Add(booleanAttr);
                            break;
                        case "DateAttribute":
                            var dateAttr = new Common.DateAttribute_T_v2();
                            dateAttr.ReadXml(reader);
                            attributes.Add(dateAttr);
                            break;
                        case "IntegerAttribute":
                            var integerAttr = new Common.IntegerAttribute_T_v2();
                            integerAttr.ReadXml(reader);
                            attributes.Add(integerAttr);
                            break;
                        case "RealAttribute":
                            var realAttr = new Common.RealAttribute_T_v2();
                            realAttr.ReadXml(reader);
                            attributes.Add(realAttr);
                            break;
                        case "StringAttribute":
                            var stringAttr = new Common.StringAttribute_T_v2();
                            stringAttr.ReadXml(reader);
                            attributes.Add(stringAttr);
                            break;
                        case "Section":
                            var section_v5 = new Section_T_v5();
                            section_v5.ReadXml(reader);
                            sections.Add(section_v5);
                            break;
                    }
                }
                if (attributes.Count > 0) AttributeList = attributes.ToArray();
                if(sections.Count > 0) Sections = sections.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }
}
