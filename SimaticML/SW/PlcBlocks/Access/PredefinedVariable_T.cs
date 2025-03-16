using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IPredefinedVariable
    {
        PredefinedVariable_TE Name { get; set; }
        int UId { get; set; }
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
    [XmlRoot("PredefinedVariable", IsNullable = false)]
    public class PredefinedVariable_T : Object_G, IPredefinedVariable
    {
        [XmlAttribute]
        public PredefinedVariable_TE Name { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Enum.TryParse<PredefinedVariable_TE>(reader.ReadContentAsString(), out var name);
                        Name = name;
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
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
