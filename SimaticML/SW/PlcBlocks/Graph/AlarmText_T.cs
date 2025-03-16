using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IAlarmText
    {
        Common.IMultiLanguageText[] Texts { get; set; }
    }
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmText", IsNullable = false)]
    public class AlarmText_T : Object_G, IAlarmText
    {
        /// <summary>
        /// Temporary change for enable of empty alarm text because of the graph alarm handling reconstruction.
        /// </summary>
        [XmlElement("MultiLanguageText")]
        public Common.IMultiLanguageText[] Texts { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();
                var texts = new List<Common.MultiLanguageText_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "MultiLanguageText":
                            var text = new Common.MultiLanguageText_T();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;
                        
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if(texts.Count > 0) Texts = texts.ToArray();
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
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmText", IsNullable = false)]
    public class AlarmText_T_v2 : AlarmText_T, IAlarmText
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
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
                        case "MultiLanguageText":
                            var text = new Common.MultiLanguageText_T_v2();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (texts.Count > 0) Texts = texts.ToArray();
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
