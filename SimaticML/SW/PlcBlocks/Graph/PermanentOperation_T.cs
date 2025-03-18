using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IPermanentOperation
    {
        Common.IComment_T Title { get; set; }
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
    [XmlRoot("PermanentOperation", IsNullable = false)]
    public class PermanentOperation_T : Object_G, IPermanentOperation
    {
        public Common.IComment_T Title { get; set; }

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
                        case nameof(Title) :
                            var title = new Common.Comment_T();
                            title.ReadXml(reader);
                            Title = title;
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
    [XmlRoot("PermanentOperation", IsNullable = false)]
    public class PermanentOperation_T_v2 : PermanentOperation_T, IPermanentOperation
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
                        case nameof(Title) :
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case nameof(FlgNet) :
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
    [XmlRoot("PermanentOperation", IsNullable = false)]
    public class PermanentOperation_T_v4 : PermanentOperation_T_v2, IPermanentOperation
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
                        case nameof(Title):
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case nameof(FlgNet) :
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
    [XmlRoot("PermanentOperation", IsNullable = false)]
    public class PermanentOperation_T_v5 : PermanentOperation_T_v4, IPermanentOperation
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
                        case nameof(Title):
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case nameof(FlgNet) :
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
    [XmlRoot("PermanentOperation", IsNullable = false)]
    public class PermanentOperation_T_v6 : PermanentOperation_T_v5, IPermanentOperation
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
                        case nameof(Title):
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case nameof(FlgNet) :
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
