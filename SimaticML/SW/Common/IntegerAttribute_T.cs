using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    public interface IIntegerAttribute
    {
        string Name { get; set; }
        bool Informative { get; set; }
        bool SystemDefined { get; set; }
        int Value { get; set; }
    }

    public interface IIntegerAttribute_v2 : IIntegerAttribute
    {
        int? UId { get; set; }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item><SW_Common/item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("IntegerAttribute", IsNullable = false)]
    public class IntegerAttribute_T : AttributeBase, IIntegerAttribute
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

        [XmlText(DataType = "integer")]
        public int Value { get; set; }

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

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadElementContentAsInt();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("IntegerAttribute", IsNullable = false)]
    public class IntegerAttribute_T_v2 : IntegerAttribute_T, IIntegerAttribute_v2
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

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadElementContentAsInt();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
