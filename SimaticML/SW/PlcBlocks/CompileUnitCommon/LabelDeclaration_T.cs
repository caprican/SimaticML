using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.CompileUnitCommon
{
    public interface ILabelDeclaration : IEnumerable<Object_G>
    {
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.CompileUnitCommon => SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LabelDeclaration", IsNullable = false)]
    public class LabelDeclaration_T : Object_G, ILabelDeclaration
    {
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T), Order = 0)]             // for NumBLs. NumBLs is informative
        //[XmlElement("Label", typeof(Access.Label_T), Order = 1)]
        //[XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        //[XmlElement("Token", typeof(Common.Token_T), Order = 3)]     // the COLON; only if separated
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
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
                            var integerAttribute = new Common.IntegerAttribute_T();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
                            break;
                        case "Label":
                            var label = new Access.Label_T();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "Token":
                            var token = new Common.Token_T();
                            token.ReadXml(reader);
                            items.Add(token);
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

        public IEnumerator<Object_G> GetEnumerator()
        {
            if (Items is null) yield break;
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.CompileUnitCommon_v2 => SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.CompileUnitCommon_v3 => SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LabelDeclaration", IsNullable = false)]
    public class LabelDeclaration_T_v2 : LabelDeclaration_T, ILabelDeclaration
    {
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), Order = 0)]     // for NumBLs. NumBLs is informative
        //[XmlElement("Label", typeof(Access.Label_T_v2), Order = 1)]
        //[XmlElement("Blank", typeof(Common.Blank_T), Order = 2 | 4)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 2 | 4)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 2 | 4)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 2 | 4)]
        //[XmlElement("Token", typeof(Common.Token_T_v2), Order = 3)]           // the COLON; only if separated
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
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
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
                            break;
                        case "Label":
                            var label = new Access.Label_T_v2();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v2();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.CompileUnitCommon_v4 => SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.CompileUnitCommon_v5 => SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LabelDeclaration", IsNullable = false)]
    public class LabelDeclaration_T_v4 : LabelDeclaration_T_v2, ILabelDeclaration
    {
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), Order = 0)]     // for NumBLs. NumBLs is informative
        //[XmlElement("Label", typeof(Access.Label_T_v4), Order = 1)]
        //[XmlElement("Blank", typeof(Common.Blank_T), Order = 2 | 4)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 2 | 4)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 2 | 4)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 2 | 4)]
        //[XmlElement("Token", typeof(Common.Token_T_v2), Order = 3)]           // the COLON; only if separated
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
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
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
                            break;
                        case "Label":
                            var label = new Access.Label_T_v4();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v3();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
