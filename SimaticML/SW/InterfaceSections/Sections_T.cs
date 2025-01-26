﻿using System;
using System.Collections.Generic;
using System.Xml;
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
    public class Sections_T : Object_G
    {
        [XmlAttribute]
        public string Datatype { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T), IsNullable = false)]
        public Common.AttributeBase[] Attributes { get; set; }

        [XmlArray("Sections")]
        [XmlElement("Section")]
        protected internal Section_T[] Items { get; set; }

        public Section_T this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                }
            }

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Items = sections.ToArray();

                reader.Skip();
            }
        }
        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
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
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] Attributes { get; set; }

        [XmlArray("Sections")]
        [XmlElement("Section")]
        protected internal new Section_T_v3[] Items { get; set; }

        public new Section_T_v3 this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                }
            }

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T_v3>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T_v3();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Items = sections.ToArray();

                reader.Skip();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
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
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] Attributes { get; set; }

        [XmlArray("Sections")]
        [XmlElement("Section")]
        protected internal new Section_T_v4[] Items { get; set; }

        public new Section_T_v4 this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                }
            }

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T_v4();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Items = sections.ToArray();

                reader.Skip();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
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
        [XmlArray("Sections")]
        [XmlElement("Section")]
        protected internal new Section_T_v5[] Items { get; set; }

        public new Section_T_v5 this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while(reader.MoveToNextAttribute())
            {
                switch(reader.LocalName)
                {
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T_v5();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Items = sections.ToArray();
            }
            reader.Skip();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
