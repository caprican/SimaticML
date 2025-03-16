using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IAlarmSupportingLanguageModule
    {
        Common.IComment_T Title { get; set; }

        IAlarmText AlarmText { get; set; }

        LADFBD.IFlgNet_T FlgNet { get; set; }

        ProgrammingLanguage_TE ProgrammingLanguage { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Interlock", IsNullable = false)]
    public class AlarmSupportingLanguageModule_T : Object_G, IAlarmSupportingLanguageModule
    {
        public Common.IComment_T Title { get; set; }

        public IAlarmText AlarmText { get; set; }

        public LADFBD.IFlgNet_T FlgNet { get; set; }

        [XmlAttribute]
        public ProgrammingLanguage_TE ProgrammingLanguage { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        reader.Skip();
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
                        case "Title":
                            var title = new Common.Comment_T();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "AlarmText":
                            var alarmText = new AlarmText_T();
                            alarmText.ReadXml(reader);
                            AlarmText = alarmText;
                            break;
                        case "FlgNet":
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
    [XmlRoot("Interlock", IsNullable = false)]
    public class AlarmSupportingLanguageModule_T_v2 : AlarmSupportingLanguageModule_T, IAlarmSupportingLanguageModule
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        reader.Skip();
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
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "AlarmText":
                            var alarmText = new AlarmText_T_v2();
                            alarmText.ReadXml(reader);
                            AlarmText = alarmText;
                            break;
                        case "FlgNet":
                            var flgNet = new LADFBD.FlgNet_T_v2();
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
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Interlock", IsNullable = false)]
    public class AlarmSupportingLanguageModule_T_v4 : AlarmSupportingLanguageModule_T_v2, IAlarmSupportingLanguageModule
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        reader.Skip();
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
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "AlarmText":
                            var alarmText = new AlarmText_T_v2();
                            alarmText.ReadXml(reader);
                            AlarmText = alarmText;
                            break;
                        case "FlgNet":
                            var flgNet = new LADFBD.FlgNet_T_v3();
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
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Interlock", IsNullable = false)]
    public class AlarmSupportingLanguageModule_T_v5 : AlarmSupportingLanguageModule_T_v4, IAlarmSupportingLanguageModule
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        reader.Skip();
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
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "AlarmText":
                            var alarmText = new AlarmText_T_v2();
                            alarmText.ReadXml(reader);
                            AlarmText = alarmText;
                            break;
                        case "FlgNet":
                            var flgNet = new LADFBD.FlgNet_T_v4();
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
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Interlock", IsNullable = false)]
    public class AlarmSupportingLanguageModule_T_v6 : AlarmSupportingLanguageModule_T_v5, IAlarmSupportingLanguageModule
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadContentAsString(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        break;

                    default:
                        reader.Skip();
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
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "AlarmText":
                            var alarmText = new AlarmText_T_v2();
                            alarmText.ReadXml(reader);
                            AlarmText = alarmText;
                            break;
                        case "FlgNet":
                            var flgNet = new LADFBD.FlgNet_T_v5();
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
}
