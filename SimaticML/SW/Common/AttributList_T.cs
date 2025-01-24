using System;
using System.Collections.Generic;
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
    public class AttributList_T : Object_G
    {
        [XmlElement("BooleanAttribute", typeof(BooleanAttribute_T))]        // A member attribute with a type restriction of boolean
        [XmlElement("IntegerAttribute", typeof(IntegerAttribute_T))]        // A member attribute with a type restriction of integer.
        [XmlElement("RealAttribute", typeof(RealAttribute_T))]              // A member attribute with a type restriction of real.
        [XmlElement("StringAttribute", typeof(StringAttribute_T))]          // A member attribute with a type restriction of string.
        public AttributeBase[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if(!reader.IsEmptyElement)
            {
                reader.Read();
                var items = new List<AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            var booleanAttr = new BooleanAttribute_T();
                            booleanAttr.ReadXml(reader);
                            items.Add(booleanAttr);
                            break;
                        case "IntegerAttribute":
                            var integerAttr = new IntegerAttribute_T();
                            integerAttr.ReadXml(reader);
                            items.Add(integerAttr);
                            break;
                        case "RealAttribute":
                            var realAttr = new RealAttribute_T();
                            realAttr.ReadXml(reader);
                            items.Add(realAttr);
                            break;
                        case "StringAttribute":
                            var stringAttr = new StringAttribute_T();
                            stringAttr.ReadXml(reader);
                            items.Add(stringAttr);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    public class AttributList_T_v2 : AttributList_T
    {
        [XmlElement("BooleanAttribute", typeof(BooleanAttribute_T_v2))]         // A member attribute with a type restriction of boolean
        [XmlElement("DateAttribute", typeof(DateAttribute_T_v2))]               // A member attribute with a type restriction of date.
        [XmlElement("IntegerAttribute", typeof(IntegerAttribute_T_v2))]         // A member attribute with a type restriction of integer.
        [XmlElement("RealAttribute", typeof(RealAttribute_T_v2))]               // A member attribute with a type restriction of real.
        [XmlElement("StringAttribute", typeof(StringAttribute_T_v2))]           // A member attribute with a type restriction of string.
        public new AttributeBase[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();
                var items = new List<AttributeBase>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BooleanAttribute":
                            var booleanAttr = new Common.BooleanAttribute_T_v2();
                            booleanAttr.ReadXml(reader);
                            items.Add(booleanAttr);
                            break;
                        case "DateAttribute":
                            var dateAttr = new Common.DateAttribute_T_v2();
                            dateAttr.ReadXml(reader);
                            items.Add(dateAttr);
                            break;
                        case "IntegerAttribute":
                            var integerAttr = new Common.IntegerAttribute_T_v2();
                            integerAttr.ReadXml(reader);
                            items.Add(integerAttr);
                            break;
                        case "RealAttribute":
                            var realAttr = new Common.RealAttribute_T_v2();
                            realAttr.ReadXml(reader);
                            items.Add(realAttr);
                            break;
                        case "StringAttribute":
                            var stringAttr = new Common.StringAttribute_T_v2();
                            stringAttr.ReadXml(reader);
                            items.Add(stringAttr);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
