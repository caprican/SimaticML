using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    public interface IWire : IEnumerable<Object_G>
    {
        int UId { get; set; }
    }
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Wire", IsNullable = false)]
    public class Wire_T : Object_G, IWire
    {
        //[XmlElement("IdentCon", typeof(IdentCon_T))]
        //[XmlElement("NameCon", typeof(NameCon_T))]
        //[XmlElement("OpenCon", typeof(OpenCon_T))]
        //[XmlElement("Openbranch", typeof(Openbranch_T))]
        //[XmlElement("Powerrail", typeof(Powerrail_T))]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int index] { get => Items[index]; set => Items[index] = value; }

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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IdentCon":
                            var identCon = new IdentCon_T();
                            identCon.ReadXml(reader);
                            items.Add(identCon);
                            break;
                        case "NameCon":
                            var nameCon = new NameCon_T();
                            nameCon.ReadXml(reader);
                            items.Add(nameCon);
                            break;
                        case "OpenCon":
                            var openCon = new OpenCon_T();
                            openCon.ReadXml(reader);
                            items.Add(openCon);
                            break;
                        case "Openbranch":
                            var openBranch = new Openbranch_T();
                            openBranch.ReadXml(reader);
                            items.Add(openBranch);
                            break;
                        case "Powerrail":
                            var powerrail = new Powerrail_T();
                            powerrail.ReadXml(reader);
                            items.Add(powerrail);
                            break;

                        default:
                            reader.Skip();
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

        public IEnumerator<Object_G> GetEnumerator()
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
