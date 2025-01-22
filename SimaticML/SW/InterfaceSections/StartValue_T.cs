using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
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
    [XmlRoot("StartValue", Namespace = "", IsNullable = false)]
    public class StartValue_T : Object_G
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
            ConstantName = reader.GetAttribute("ConstantName");

            _ = bool.TryParse(reader.GetAttribute("IsBulkValue"), out var systemDefined);
            IsBulkValue = systemDefined;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            
        }
    }

}
