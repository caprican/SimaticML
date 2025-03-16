using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IConstant
    {
        IConstantType ConstantType { get; set; }
        IConstantValue ConstantValue { get; set; }

        Common.AttributeBase[] Attributes { get; set; }

        string Name { get; set; }
    }

    public interface IConstant_v2 : IConstant
    {
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Constant", IsNullable = false)]
    public class Constant_T : Object_G, IConstant
    {
        public IConstantType ConstantType { get; set; }

        public IConstantValue ConstantValue { get; set; }

        /// <summary>
        /// for Format and FormatFlags. They are informative..
        /// </summary>
        [XmlElement("StringAttribute")]
        public Common.AttributeBase[] Attributes { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(ConstantType) :
                            var constantType = new ConstantType_T();
                            constantType.ReadXml(reader);
                            ConstantType = constantType;
                            break;

                        case nameof(ConstantValue) :
                            var constantValue = new ConstantValue_T();
                            constantValue.ReadXml(reader);
                            ConstantValue = constantValue;
                            break;
                        case "StringAttribute":
                            var stringAttribute = new Common.StringAttribute_T();
                            stringAttribute.ReadXml(reader);
                            attributes.Add(stringAttribute);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (attributes.Count > 0) Attributes = attributes.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
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
    [XmlRoot("Constant", IsNullable = false)]
    public class Constant_T_v2 : Constant_T, IConstant_v2
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
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(ConstantType) :
                            var constantType = new ConstantType_T_v2();
                            constantType.ReadXml(reader);
                            ConstantType = constantType;
                            break;

                        case nameof(ConstantValue) :
                            var constantValue = new ConstantValue_T_v2();
                            constantValue.ReadXml(reader);
                            ConstantValue = constantValue;
                            break;
                        case "StringAttribute":
                            var stringAttribute = new Common.StringAttribute_T_v2();
                            stringAttribute.ReadXml(reader);
                            attributes.Add(stringAttribute);
                            break;
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            attributes.Add(booleanAttribute);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (attributes.Count > 0) Attributes = attributes.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
