using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LineComment", IsNullable = false)]
    public class LineComment_T : Comment_G
    {
        /// <summary>
        /// For NumBLs in STL. NumBLs is the count of the blank spaces before the actual text in the LineComment.
        /// This is informative.
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }

        /// <summary>
        /// Denotes if the comment is at the end of the line (using //) or inside the line (using /* */)
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Inserted { get; set; } = false;

        /// <summary>
        /// the value of the comment
        /// </summary>
        [XmlElement("Text", typeof(Text_T))]
        private Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Inserted):
                        Inserted = reader.ReadContentAsBoolean();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new IntegerAttribute_T();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "Text":
                            var text = new Text_T();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                    }
                }
                if(items.Count > 0) Items = items.ToArray();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LineComment", IsNullable = false)]
    public class LineComment_T_v2 : LineComment_T
    {
        /// <summary>
        /// For NumBLs in STL. NumBLs is the count of the blank spaces before the actual text in the LineComment.
        /// This is informative.
        /// </summary>
        public new IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        /// <summary>
        /// the value of the comment
        /// </summary>
        [XmlElement("Text", typeof(Text_T_v2))]
        private Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool NoClosingBracket { get; set; } = false;

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Inserted):
                        Inserted = reader.ReadContentAsBoolean();
                        break;
                    case nameof(NoClosingBracket):
                        NoClosingBracket = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "Text":
                            var text = new Text_T_v2();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

    /// <remarks>
    /// <list type="bullet">
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LineComment", IsNullable = false)]
    public class LineComment_T_v3 : LineComment_T_v2
    {
        /// <summary>
        /// the value of the comment
        /// </summary>
        [XmlElement("Comment", typeof(Comment_T_v2))]
        [XmlElement("Text", typeof(Text_T_v2))]
        private Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Inserted):
                        Inserted = reader.ReadContentAsBoolean();
                        break;
                    case nameof(NoClosingBracket):
                        NoClosingBracket = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "Text":
                            var text = new Text_T_v2();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "Comment":
                            var comment = new Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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
}
