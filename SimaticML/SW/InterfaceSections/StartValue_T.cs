using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    public interface IStartValue
    {
        string ConstantName { get; set; }
        bool IsBulkValue { get; set; }
        bool Informative { get; set; }
        string Value { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StartValue", IsNullable = false)]
    public class StartValue_T : Object_G, IStartValue
    {
        [XmlAttribute]
        public string ConstantName { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsBulkValue { get; set; } = false;

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ConstantName):
                        ConstantName = reader.ReadContentAsString();
                        break;
                    case nameof(IsBulkValue):
                        IsBulkValue = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    
                    default:
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
