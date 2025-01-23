using System;
using System.Collections.Generic;
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
    [XmlRoot("Constant", IsNullable = false)]
    public class Constant_T : Object_G
    {
        public ConstantType_T ConstantType { get; set; }

        public ConstantValue_T ConstantValue { get; set; }

        /// <summary>
        /// for Format and FormatFlags. They are informative..
        /// </summary>
        [XmlElement("StringAttribute")]
        public Common.AttributeBase[] Attributes { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "ConstantType":
                            ConstantType = new ConstantType_T();
                            ConstantType.ReadXml(reader);
                            break;

                        case "ConstantValue":
                            ConstantValue = new ConstantValue_T();
                            ConstantValue.ReadXml(reader);
                            break;
                        case "StringAttribute":
                            var stringAttribute = new Common.StringAttribute_T();
                            stringAttribute.ReadXml(reader);
                            attributes.Add(stringAttribute);
                            break;
                    }
                }
                if (attributes.Count > 0) Attributes = attributes.ToArray();

                reader.ReadEndElement();
            }
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
    public class Constant_T_v2 : Constant_T
    {
        public new ConstantType_T_v2 ConstantType { get; set; }

        public new ConstantValue_T_v2 ConstantValue { get; set; }

        /// <summary>
        /// for Format and FormatFlags. They are informative..
        /// </summary>
        [XmlElement("StringAttribute", typeof(Common.StringAttribute_T_v2))]
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        public new Common.AttributeBase[] Attributes { get; set; }

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var attributes = new List<Common.AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "ConstantType":
                            ConstantType = new ConstantType_T_v2();
                            ConstantType.ReadXml(reader);
                            break;

                        case "ConstantValue":
                            ConstantValue = new ConstantValue_T_v2();
                            ConstantValue.ReadXml(reader);
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
                    }
                }
                if (attributes.Count > 0) Attributes = attributes.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
