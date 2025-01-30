using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Step", IsNullable = false)]
    public class Step_T : Object_G
    {
        public Common.Comment_T Comment { get; set; }

        public Actions_T Actions { get; set; }

        public Supervisions_T Supervisions { get; set; }

        public Interlocks_T Interlocks { get; set; }

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
                        case "Comment":
                            Comment = new Common.Comment_T();
                            Comment.ReadXml(reader);
                            break;
                        case "Actions":
                            Actions = new Actions_T();
                            Actions.ReadXml(reader);
                            break;
                        case "Supervisions":
                            Supervisions = new Supervisions_T();
                            Supervisions.ReadXml(reader);
                            break;
                        case "Interlocks":
                            Interlocks = new Interlocks_T();
                            Interlocks.ReadXml(reader);
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
    public class Step_T_v2 : Step_T
    {
        public new Common.Comment_T_v2 Comment { get; set; }

        public new Supervisions_T_v2 Supervisions { get; set; }

        [XmlArrayItem("MultiLanguageText", IsNullable = false)]
        public Common.MultiLanguageText_T_v2[] StepName { get; set; }

        public new Actions_T_v2 Actions { get; set; }

        public new Interlocks_T_v2 Interlocks { get; set; }

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
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Actions":
                            Actions = new Actions_T_v2();
                            Actions.ReadXml(reader);
                            break;
                        case "Supervisions":
                            Supervisions = new Supervisions_T_v2();
                            Supervisions.ReadXml(reader);
                            break;
                        case "Interlocks":
                            Interlocks = new Interlocks_T_v2();
                            Interlocks.ReadXml(reader);
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
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
    public class Step_T_v4 : Step_T_v2
    {
        public new Actions_T_v4 Actions { get; set; }

        public new Supervisions_T_v4 Supervisions { get; set; }

        public new Interlocks_T_v4 Interlocks { get; set; }

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
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Actions":
                            Actions = new Actions_T_v4();
                            Actions.ReadXml(reader);
                            break;
                        case "Supervisions":
                            Supervisions = new Supervisions_T_v4();
                            Supervisions.ReadXml(reader);
                            break;
                        case "Interlocks":
                            Interlocks = new Interlocks_T_v4();
                            Interlocks.ReadXml(reader);
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
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
    public class Step_T_v5 : Step_T_v4
    {
        public new Supervisions_T_v5 Supervisions { get; set; }

        public new Actions_T_v5 Actions { get; set; }

        public new Interlocks_T_v5 Interlocks { get; set; }

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
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Actions":
                            Actions = new Actions_T_v5();
                            Actions.ReadXml(reader);
                            break;
                        case "Supervisions":
                            Supervisions = new Supervisions_T_v5();
                            Supervisions.ReadXml(reader);
                            break;
                        case "Interlocks":
                            Interlocks = new Interlocks_T_v5();
                            Interlocks.ReadXml(reader);
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
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
    public class Step_T_v6 : Step_T_v5
    {
        public new Actions_T_v6 Actions { get; set; }

        public new Supervisions_T_v6 Supervisions { get; set; }

        public new Interlocks_T_v6 Interlocks { get; set; }

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
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Actions":
                            Actions = new Actions_T_v6();
                            Actions.ReadXml(reader);
                            break;
                        case "Supervisions":
                            Supervisions = new Supervisions_T_v6();
                            Supervisions.ReadXml(reader);
                            break;
                        case "Interlocks":
                            Interlocks = new Interlocks_T_v6();
                            Interlocks.ReadXml(reader);
                            break;
                        case "StepName":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
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
