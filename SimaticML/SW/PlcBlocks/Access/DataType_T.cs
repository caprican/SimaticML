using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IDataType
    {
        bool? Informative { get; set; }
        int? UId { get; set; }
        string Value { get; set; }
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
    [XmlRoot("DataType", IsNullable = false)]
    public class DataType_T : Object_G, IDataType
    {
        [XmlAttribute]
        public bool? Informative { get; set; } = null;
        [XmlIgnore]
        public bool InformativeSpecified { get; set; }

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        InformativeSpecified = true;
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;

                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadInnerXml();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
