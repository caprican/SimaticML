using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.STL
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    ///          SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    ///          SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StatementList", IsNullable = false)]
    public class StatementList_T : Object_G
    {
        [XmlElement("StlStatement")]
        public StlStatement_T[] StlStatement { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<StlStatement_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "StlStatement":
                            var state = new StlStatement_T();
                            state.ReadXml(reader);
                            items.Add(state);
                            break;
                    }
                }
                if (items.Count > 0) StlStatement = items.ToArray();
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
