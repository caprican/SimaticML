using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IStep
    {
        Common.IComment_T Comment { get; set; }

        IActions Actions { get; set; }

        ISupervisions Supervisions { get; set; }

        IInterlocks Interlocks { get; set; }

        bool IsMissing { get; set; }

        int Number { get; set; }

        bool Init { get; set; }

        string Name { get; set; }

        string MaximumStepTime { get; set; }

        string WarningTime { get; set; }
    }

    public interface IStep_v2 : IStep
    {
        Common.IMultiLanguageText[] StepName { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", IsNullable = false)]
    public class Step_T : Object_G, IStep
    {
        public Common.IComment_T Comment { get; set; }

        public IActions Actions { get; set; }

        public ISupervisions Supervisions { get; set; }

        public IInterlocks Interlocks { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsMissing { get; set; } = false;

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Init { get; set; } = false;

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string MaximumStepTime { get; set; }

        [XmlAttribute]
        public string WarningTime { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Init):
                        Init = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(MaximumStepTime):
                        MaximumStepTime = reader.ReadContentAsString();
                        break;
                    case nameof(WarningTime):
                        WarningTime = reader.ReadContentAsString();
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(Actions) :
                            var actions = new Actions_T();
                            actions.ReadXml(reader);
                            Actions = actions;
                            break;
                        case nameof(Supervisions) :
                            var supervisions = new Supervisions_T();
                            supervisions.ReadXml(reader);
                            Supervisions = supervisions;
                            break;
                        case nameof(Interlocks) :
                            var interlocks = new Interlocks_T();
                            interlocks.ReadXml(reader);
                            Interlocks = interlocks;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }

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
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", IsNullable = false)]
    public class Step_T_v2 : Step_T, IStep_v2
    {
        [XmlArrayItem("MultiLanguageText", IsNullable = false)]
        public Common.IMultiLanguageText[] StepName { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Init):
                        Init = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(MaximumStepTime):
                        MaximumStepTime = reader.ReadContentAsString();
                        break;
                    case nameof(WarningTime):
                        WarningTime = reader.ReadContentAsString();
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.IMultiLanguageText>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(Actions) :
                            var actions = new Actions_T_v2();
                            actions.ReadXml(reader);
                            Actions = actions;
                            break;
                        case nameof(Supervisions) :
                            var supervisions = new Supervisions_T_v2();
                            supervisions.ReadXml(reader);
                            Supervisions = supervisions;
                            break;
                        case nameof(Interlocks) :
                            var interlocks = new Interlocks_T_v2();
                            interlocks.ReadXml(reader);
                            Interlocks = interlocks;
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) StepName = texts.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", IsNullable = false)]
    public class Step_T_v4 : Step_T_v2, IStep_v2
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Init):
                        Init = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(MaximumStepTime):
                        MaximumStepTime = reader.ReadContentAsString();
                        break;
                    case nameof(WarningTime):
                        WarningTime = reader.ReadContentAsString();
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.IMultiLanguageText>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(Actions) :
                            var actions = new Actions_T_v4();
                            actions.ReadXml(reader);
                            Actions = actions;
                            break;
                        case nameof(Supervisions) :
                            var supervisions = new Supervisions_T_v4();
                            supervisions.ReadXml(reader);
                            Supervisions = supervisions;
                            break;
                        case nameof(Interlocks) :
                            var interlocks = new Interlocks_T_v4();
                            interlocks.ReadXml(reader);
                            Interlocks = interlocks;
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) StepName = texts.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", IsNullable = false)]
    public class Step_T_v5 : Step_T_v4, IStep_v2
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Init):
                        Init = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(MaximumStepTime):
                        MaximumStepTime = reader.ReadContentAsString();
                        break;
                    case nameof(WarningTime):
                        WarningTime = reader.ReadContentAsString();
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.IMultiLanguageText>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(Actions) :
                            var actions = new Actions_T_v5();
                            actions.ReadXml(reader);
                            Actions = actions;
                            break;
                        case nameof(Supervisions) :
                            var supervisions = new Supervisions_T_v5();
                            supervisions.ReadXml(reader);
                            Supervisions = supervisions;
                            break;
                        case nameof(Interlocks) :
                            var interlocks = new Interlocks_T_v5();
                            interlocks.ReadXml(reader);
                            Interlocks = interlocks;
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) StepName = texts.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", IsNullable = false)]
    public class Step_T_v6 : Step_T_v5, IStep_v2
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Init):
                        Init = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(MaximumStepTime):
                        MaximumStepTime = reader.ReadContentAsString();
                        break;
                    case nameof(WarningTime):
                        WarningTime = reader.ReadContentAsString();
                        break;
                    
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.IMultiLanguageText>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(Actions) :
                            var actions = new Actions_T_v6();
                            actions.ReadXml(reader);
                            Actions = actions;
                            break;
                        case nameof(Supervisions) :
                            var supervisions = new Supervisions_T_v6();
                            supervisions.ReadXml(reader);
                            Supervisions = supervisions;
                            break;
                        case nameof(Interlocks) :
                            var interlocks = new Interlocks_T_v6();
                            interlocks.ReadXml(reader);
                            Interlocks = interlocks;
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) StepName = texts.ToArray();

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
