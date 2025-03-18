using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IIdentRef
    {
        Common.IComment_T Comment { get; set; }

        Common.IViewInfo ViewInfo { get; set; }

        int UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("IdentRef", IsNullable = false)]
    public class IdentRef_T : Object_G, IIdentRef
    {
        public Common.IComment_T Comment { get; set; }

        public Common.IViewInfo ViewInfo { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
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
                        case nameof(ViewInfo) :
                            var viewInfo = new Common.ViewInfo_T();
                            viewInfo.ReadXml(reader);
                            ViewInfo = viewInfo;
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
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("IdentRef", IsNullable = false)]
    public class IdentRef_T_v2 : IdentRef_T, IIdentRef
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
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
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case nameof(ViewInfo) :
                            var viewInfo = new Common.ViewInfo_T_v2();
                            viewInfo.ReadXml(reader);
                            ViewInfo = viewInfo;
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
