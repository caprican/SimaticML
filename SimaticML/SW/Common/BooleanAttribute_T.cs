using System;
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
    [DebuggerDisplay("{Name} = {Value}")]
    [XmlRoot("BooleanAttribute", IsNullable = false)]
    public class BooleanAttribute_T : AttributeBase
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
        public bool SystemDefined { get; set; } = false;

        [XmlText]
        public bool Value  { get; set;  }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(SystemDefined):
                        SystemDefined = reader.ReadContentAsBoolean();
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadElementContentAsBoolean();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
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
    [DebuggerDisplay("{Name} = {Value}")]
    [XmlRoot("BooleanAttribute", IsNullable = false)]
    public class BooleanAttribute_T_v2 : BooleanAttribute_T
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(SystemDefined):
                        SystemDefined = reader.ReadContentAsBoolean();
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }

            }

            reader.MoveToContent();
            Value = reader.ReadElementContentAsBoolean();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

}