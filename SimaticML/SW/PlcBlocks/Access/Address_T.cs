using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Address", IsNullable=false)]
    public class Address_T : Object_G
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
            _ = Enum.TryParse<Area_TE>(reader.GetAttribute("Area"), out var area);
            Area = area;

            Type = reader.GetAttribute("Type");

            BlockNumberSpecified = int.TryParse(reader.GetAttribute("BlockNumber"), out var blockNumber);
            if (BlockNumberSpecified) BlockNumber = blockNumber;

            BitOffsetSpecified = int.TryParse(reader.GetAttribute("BitOffset"), out var bitOffset);
            if (BitOffsetSpecified) BitOffset = bitOffset;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
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
    public class Address_T_v2 : Address_T
    {
        [XmlElement("BooleanAttribute")]
        public Common.BooleanAttribute_T_v2[] Items { get; set; }

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<Area_TE>(reader.GetAttribute("Area"), out var area);
            Area = area;

            Type = reader.GetAttribute("Type");

            BlockNumberSpecified = int.TryParse(reader.GetAttribute("BlockNumber"), out var blockNumber);
            if (BlockNumberSpecified) BlockNumber = blockNumber;

            BitOffsetSpecified = int.TryParse(reader.GetAttribute("BitOffset"), out var bitOffset);
            if (BitOffsetSpecified) BitOffset = bitOffset;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }
}
