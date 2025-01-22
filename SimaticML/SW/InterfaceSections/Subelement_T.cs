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
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T : IXmlSerializable
    {
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Path { get; set; }

        public XmlSchema GetSchema() => null;

        public virtual void ReadXml(XmlReader reader)
        {
            Path = reader.GetAttribute("Path");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Comment":
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T_v3 : Subelement_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public new object[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Path = reader.GetAttribute("Path");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    [XmlRoot("Subelement", Namespace = "", IsNullable = false)]
    public class Subelement_T_v5 : Subelement_T_v3
    {
        [XmlElement("AssignedProDiagFB", typeof(string))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        public new object[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Path = reader.GetAttribute("Path");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AssignedProDiagFB":
                            /// TODO : Read string
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }
}
