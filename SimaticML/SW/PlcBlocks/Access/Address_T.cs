using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IAdress
    {
        Area_TE Area { get; set; }
        string Type { get; set; }
        int? BlockNumber { get; set; }
        int? BitOffset { get; set; }
        bool Informative { get; set; }
    }

    public interface IAdress_v2 : IAdress
    {
        Common.IBooleanAttribute[] Attributes { get; set; }
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Address", IsNullable=false)]
    public class Address_T : Object_G, IAdress
    {
        [XmlAttribute]
        public Area_TE Area { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        /// <summary>
        /// for DB access
        /// </summary>
        [XmlAttribute]
        public int? BlockNumber { get; set; } = null;
        [XmlIgnore]
        public bool BlockNumberSpecified { get; set; }

        /// <summary>
        /// In general it is Byte * 8 + Bit. But if it is used for addressing a DB we will find the number of the DB here (e.g. "DB12" ->12).
        /// </summary>
        [XmlAttribute]
        public int? BitOffset { get; set; } = null;
        [XmlIgnore]
        public bool BitOffsetSpecified { get; set; }

        /// <summary>
        /// if true, the import unnoted it
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        BlockNumberSpecified = true;
                        break;
                    case nameof(BlockNumber):
                        BlockNumber = reader.ReadContentAsInt();
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsInt();
                        BitOffsetSpecified = true;
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    
                    default:
                        break;
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
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Address", IsNullable = false)]
    public class Address_T_v2 : Address_T, IAdress_v2
    {
        [XmlElement("BooleanAttribute")]
        public Common.IBooleanAttribute[] Attributes { get; set; }

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        BlockNumberSpecified = true;
                        break;
                    case nameof(BlockNumber):
                        BlockNumber = reader.ReadContentAsInt();
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsInt();
                        BitOffsetSpecified = true;
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();
                var items = new List<Common.BooleanAttribute_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            var booleanAttr = new Common.BooleanAttribute_T_v2();
                            booleanAttr.ReadXml(reader);
                            items.Add(booleanAttr);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Attributes = items.ToArray();
                reader.ReadEndElement();
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
