﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StringAttribute", IsNullable = false)]
    [DebuggerDisplay("{Name} = {Value}")]
    public class StringAttribute_T : AttributeBase
    {
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Exported only with ReadOnly option, ignored during import.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        /// <summary>
        /// An attribute of attribute, denotes if it is defined by a user or the system itself. In V14, if exists it is always true.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(true)]
        public bool SystemDefined { get; set; } = true;

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            _ = bool.TryParse(reader.GetAttribute("SystemDefined"), out var systemDefined);
            SystemDefined = systemDefined;

            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StringAttribute", IsNullable = false)]
    [DebuggerDisplay("{Name} = {Value}")]
    public class StringAttribute_T_v2 : StringAttribute_T
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            _ = bool.TryParse(reader.GetAttribute("SystemDefined"), out var systemDefined);
            SystemDefined = systemDefined;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if(UIdSpecified) UId = uId;

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
