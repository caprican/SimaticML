using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.STL
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", IsNullable = false)]
    public class StlStatement_T : Object_G, IEnumerable<Object_G>
    {
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T), Order = 4)]
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
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "StlToken":
                            var token = new StlToken_T();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Access":
                            var access = new Access.Access_T();
                            access.ReadXml(reader);
                            items.Add(access);
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
            foreach(var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", IsNullable = false)]
    public class StlStatement_T_v2 : StlStatement_T, IEnumerable<Object_G>
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v2), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v2), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v2), Order = 4)]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

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
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T_v2();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "StlToken":
                            var token = new StlToken_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Access":
                            var access = new Access.Access_T_v2();
                            access.ReadXml(reader);
                            items.Add(access);
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", IsNullable = false)]
    public class StlStatement_T_v3 : StlStatement_T_v2, IEnumerable<Object_G>
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v2), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v2), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v3), Order = 4)]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

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
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T_v2();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "StlToken":
                            var token = new StlToken_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Access":
                            var access = new Access.Access_T_v3();
                            access.ReadXml(reader);
                            items.Add(access);
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", IsNullable = false)]
    public class StlStatement_T_v4 : StlStatement_T_v2, IEnumerable<Object_G>
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v4), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v4), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v4), Order = 4)]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

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
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T_v4();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "StlToken":
                            var token = new StlToken_T_v4();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Access":
                            var access = new Access.Access_T_v4();
                            access.ReadXml(reader);
                            items.Add(access);
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", IsNullable = false)]
    public class StlStatement_T_v5 : StlStatement_T_v4, IEnumerable<Object_G>
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v4), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v4), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v5), Order = 4)]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

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
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T_v4();
                            label.ReadXml(reader);
                            items.Add(label);
                            break;
                        case "StlToken":
                            var token = new StlToken_T_v4();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Access":
                            var access = new Access.Access_T_v5();
                            access.ReadXml(reader);
                            items.Add(access);
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
