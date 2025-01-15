using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    ///          SW_InterfaceSections_v3 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    ///          SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StartValue", Namespace = "", IsNullable = false)]
    public class StartValue_T
    {
        public StartValue_T()
        {
            IsBulkValue = false;
            Informative = false;
        }

        [XmlAttribute]
        public string ConstantName { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool IsBulkValue { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

}
