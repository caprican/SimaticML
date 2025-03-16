using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IStatusword
    {
        Statusword_TE Combination { get; set; }
    }

    /// <summary>
    /// Only for S7-300/400/WinAC
    /// </summary>
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
    [XmlRoot("Statusword", IsNullable = false)]
    public class Statusword_T : Object_G, IStatusword
    {
        [XmlAttribute]
        public Statusword_TE Combination { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Combination):
                        Enum.TryParse<Statusword_TE>(reader.ReadContentAsString(), out var combination);
                        Combination = combination;
                        break;

                    default:
                        reader.Skip();
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
