using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("NewLine", IsNullable = false)]
    public class NewLine_T : Comment_G
    {
        [XmlAttribute(DataType = "positiveInteger")]
        [DefaultValue("1")]
        public uint Num { get; set; } = 1;

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = uint.TryParse(reader.GetAttribute("Num"), out var num);
            Num = num;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if(UIdSpecified) UId = uId;
        }

        public override void WriteXml(XmlWriter writer)
        {
            
        }
    }
}
