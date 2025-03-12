using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IInstruction_T : IEnumerable<Object_G>
    {
        string Name { get; set; }
        string Version { get; set; }
    }

    public interface IInstruction_T_v2 : IInstruction_T
    {
        bool Informative { get; set; }
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T : Object_G, IInstruction_T
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        //[XmlElement("Comment", typeof(Common.Comment_T), Order = 0 | 2)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T), Order = 0 | 2)]
        //[XmlElement("Token", typeof(Common.Token_T), Order = 1)]
        //[XmlElement("TemplateValue", typeof(TemplateValue_T), Order = 3)]
        //[XmlElement("Instance", typeof(Instance_T), Order = 4)]
        //[XmlElement("Parameter", typeof(Parameter_T), Order = 5)]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
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
                        case "Token":
                            var token = new Common.Token_T();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "TemplateValue":
                            var templateValue = new TemplateValue_T();
                            templateValue.ReadXml(reader);
                            items.Add(templateValue);
                            break;
                        case "Instance":
                            var instance = new Instance_T();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
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
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v2 : Instruction_T, IInstruction_T_v2
    {
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        //[XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("TemplateValue", typeof(TemplateValue_T_v2), Order = 0)]
        //[XmlElement("Token", typeof(Common.Token_T_v2), Order = 0 | 2 | 5 | 8)]
        //[XmlElement("Instance", typeof(Instance_T_v2), Order = 1)]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T), Order = 4)]
        //[XmlElement("Parameter", typeof(Parameter_T_v2), Order = 7)]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
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
                        case "TemplateValue":
                            var templateValue = new TemplateValue_T_v2();
                            templateValue.ReadXml(reader);
                            items.Add(templateValue);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v2();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v2();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v3 : Instruction_T_v2, IInstruction_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("Instance", typeof(Instance_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T_v3))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Parameter", typeof(Parameter_T_v3))]
        //[XmlElement("TemplateValue", typeof(TemplateValue_T_v2))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
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
                        case "TemplateValue":
                            var templateValue = new TemplateValue_T_v2();
                            templateValue.ReadXml(reader);
                            items.Add(templateValue);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v2();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T_v3();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v3();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v4 : Instruction_T_v3, IInstruction_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("Instance", typeof(Instance_T_v4))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T_v4))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Parameter", typeof(Parameter_T_v4))]
        //[XmlElement("TemplateValue", typeof(TemplateValue_T_v2))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
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
                        case "TemplateValue":
                            var templateValue = new TemplateValue_T_v2();
                            templateValue.ReadXml(reader);
                            items.Add(templateValue);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v4();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T_v4();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v4();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instruction", Namespace = "", IsNullable = false)]
    public class Instruction_T_v5 : Instruction_T_v4, IInstruction_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("Instance", typeof(Instance_T_v5))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T_v5))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Parameter", typeof(Parameter_T_v5))]
        //[XmlElement("TemplateValue", typeof(TemplateValue_T_v2))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
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
                        case "TemplateValue":
                            var templateValue = new TemplateValue_T_v2();
                            templateValue.ReadXml(reader);
                            items.Add(templateValue);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v5();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T_v5();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v5();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
