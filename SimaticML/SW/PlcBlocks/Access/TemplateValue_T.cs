using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access (SW.Common)</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("TemplateValue", Namespace = "", IsNullable = false)]
    public class TemplateValue_T
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public TemplateType_TE Type { get; set; }

        [XmlText]
        public string Value { get; set; }
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
    [XmlRoot("TemplateValue", Namespace = "", IsNullable = false)]
    public class TemplateValue_T_v2 : TemplateValue_T
    {
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
