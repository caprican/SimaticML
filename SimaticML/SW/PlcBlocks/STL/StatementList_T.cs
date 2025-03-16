using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.STL
{
    public interface IStatementList : IEnumerable<IStlStatement>
    {

    }
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    ///          SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    ///          SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StatementList", IsNullable = false)]
    public class StatementList_T : Object_G, IStatementList
    {
        protected internal IStlStatement[] Items { get; set; }
        public IStlStatement this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<IStlStatement>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.NamespaceURI)
                    {
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StatementList":
                            var stl = new StlStatement_T();
                            stl.ReadXml(reader);
                            items.Add(stl);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StatementList/v2":
                            var stl_v2 = new StlStatement_T_v2();
                            stl_v2.ReadXml(reader);
                            items.Add(stl_v2);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StatementList/v3":
                            var stl_v3 = new StlStatement_T_v3();
                            stl_v3.ReadXml(reader);
                            items.Add(stl_v3);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StatementList/v4":
                            var stl_v4 = new StlStatement_T_v4();
                            stl_v4.ReadXml(reader);
                            items.Add(stl_v4);
                            break;
                        case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StatementList/v5":
                            var stl_v5 = new StlStatement_T_v5();
                            stl_v5.ReadXml(reader);
                            items.Add(stl_v5);
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

        public IEnumerator<IStlStatement> GetEnumerator()
        {
            if (Items is null) yield break;
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
