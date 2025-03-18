using System.Collections.Generic;
using System.Xml;
using SimaticML.SW.Blocks;
using SimaticML.SW.Tags;

using SimaticML.SW.WatchAndForceTables;

namespace SimaticML.Helpers
{
    public static class ObjectListHelper
    {
        public static Object_T[] Read(XmlReader reader)
        {
            var items = new List<Object_T>();
            while (reader.MoveToContent() == XmlNodeType.Element)
            {
                switch (reader.Name)
                {
                    case "MultilingualText":
                        var text = new MultilingualText_T();
                        text.ReadXml(reader);
                        items.Add(text);
                        break;
                    case "MultilingualTextItem":
                        var textItem = new MultilingualTextItem_T();
                        textItem.ReadXml(reader);
                        items.Add(textItem);
                        break;
                    case "SW.Blocks.CompileUnit":
                        var compileUnit = new CompileUnit();
                        compileUnit.ReadXml(reader);
                        items.Add(compileUnit);
                        break;
                    case "SW.Tags.PlcTag":
                        var plcTag = new PlcTagTable();
                        plcTag.ReadXml(reader);
                        items.Add(plcTag);
                        break;
                    case "SW.Tags.PlcUserConstant":
                        var plcConstant = new PlcUserConstant();
                        plcConstant.ReadXml(reader);
                        items.Add(plcConstant);
                        break;
                    case "SW.WatchAndForceTables.PlcWatchTableEntry":
                        var plcWatchEntry = new PlcWatchTableEntry();
                        plcWatchEntry.ReadXml(reader);
                        items.Add(plcWatchEntry);
                        break;
                    case "SW.WatchAndForceTables.PlcTableCommentEntry":
                        var plcWatchComment = new PlcTableCommentEntry();
                        plcWatchComment.ReadXml(reader);
                        items.Add(plcWatchComment);
                        break;

                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.ReadEndElement();

            return items.ToArray();
        }
    }
}
