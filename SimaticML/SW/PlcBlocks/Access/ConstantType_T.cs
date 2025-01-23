﻿using System;
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
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "ConstantType", IsNullable = false)]
    public class ConstantType_T : Object_G
    {
        [XmlAttribute]
        public bool? Informative { get; set; } = null;
        [XmlIgnore]
        public bool InformativeSpecified { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            InformativeSpecified = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            if(InformativeSpecified) Informative = informative;

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
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
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "ConstantType", IsNullable = false)]
    public class ConstantType_T_v2 : ConstantType_T
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            InformativeSpecified = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            if (InformativeSpecified) Informative = informative;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
