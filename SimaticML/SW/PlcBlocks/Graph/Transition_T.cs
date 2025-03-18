using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface ITransition
    {
        Common.IComment_T Comment { get; set; }
        LADFBD.IFlgNet_T FlgNet { get; set; }
        bool IsMissing { get; set; }
        string Name { get; set; }
        int Number { get; set; }
        ProgrammingLanguage_TE ProgrammingLanguage { get; set; }
    }

    public interface ITransition_v2 : ITransition
    {
        Common.IMultiLanguageText_v2[] TransitionName { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Transition", IsNullable = false)]
    public class Transition_T : Object_G, ITransition
    {
        public Common.IComment_T Comment { get; set; }

        public LADFBD.IFlgNet_T FlgNet { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsMissing { get; set; } = false;

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public ProgrammingLanguage_TE ProgrammingLanguage { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
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
                        case nameof(FlgNet) :
                            var flgNet = new LADFBD.FlgNet_T();
                            flgNet.ReadXml(reader);
                            FlgNet = flgNet;
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
    [XmlRoot("Transition", IsNullable = false)]
    public class Transition_T_v2 : Transition_T, ITransition_v2
    {
        [XmlArrayItem("MultiLanguageText", IsNullable = false)]
        public Common.IMultiLanguageText_v2[] TransitionName { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(IsMissing):
                        IsMissing = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.MultiLanguageText_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(FlgNet) :
                            var flgNet = new LADFBD.FlgNet_T_v2();
                            flgNet.ReadXml(reader);
                            FlgNet = flgNet;
                            break;
                        case "TransitionName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) TransitionName = texts.ToArray();
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
    [XmlRoot("Transition", IsNullable = false)]
    public class Transition_T_v4 : Transition_T_v2, ITransition_v2
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
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.MultiLanguageText_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(FlgNet) :
                            var flgNet = new LADFBD.FlgNet_T_v3();
                            flgNet.ReadXml(reader);
                            FlgNet = flgNet;
                            break;
                        case "TransitionName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) TransitionName = texts.ToArray();
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
    [XmlRoot("Transition", IsNullable = false)]
    public class Transition_T_v5 : Transition_T_v4, ITransition_v2
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
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.MultiLanguageText_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(FlgNet) :
                            var flgNet = new LADFBD.FlgNet_T_v4();
                            flgNet.ReadXml(reader);
                            FlgNet = flgNet;
                            break;
                        case "TransitionName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) TransitionName = texts.ToArray();
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
    [XmlRoot("Transition", IsNullable = false)]
    public class Transition_T_v6 : Transition_T_v5, ITransition_v2
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
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<Common.MultiLanguageText_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(FlgNet) :
                            var flgNet = new LADFBD.FlgNet_T_v5();
                            flgNet.ReadXml(reader);
                            FlgNet = flgNet;
                            break;
                        case "TransitionName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) TransitionName = texts.ToArray();
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
