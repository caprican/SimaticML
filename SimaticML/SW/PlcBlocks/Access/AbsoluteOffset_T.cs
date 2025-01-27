using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list> 
    /// </remarks>
    [Serializable]
    [XmlRoot("AbsoluteOffset", IsNullable = false)]
    public class AbsoluteOffset_T : Object_G
    {
        /// <summary>
        /// Byte * 8 + Bit
        /// </summary>
        [XmlAttribute]
        public int BitOffset { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsInt();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
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
}
