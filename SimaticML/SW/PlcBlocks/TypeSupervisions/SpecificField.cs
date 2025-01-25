using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class SpecificField : Object_G
    {
        [XmlArrayItem("AssociatedValue", IsNullable = false)]
        public AssociatedValue[] AssociatedValues { get; set; }

        public SpecificFieldText SpecificFieldText { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var associatedValues = new List<AssociatedValue>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AssociatedValue":
                            var value = new AssociatedValue();
                            value.ReadXml(reader);
                            associatedValues.Add(value);
                            break;
                        case "SpecificFieldText":
                            SpecificFieldText = new SpecificFieldText();
                            SpecificFieldText.ReadXml(reader);
                            break;
                    }
                }
                if (associatedValues.Count > 0) AssociatedValues = associatedValues.ToArray();
            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class SpecificField_v2 : SpecificField
    {
        public new SpecificFieldText_v2 SpecificFieldText { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var associatedValues = new List<AssociatedValue>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AssociatedValue":
                            var value = new AssociatedValue();
                            value.ReadXml(reader);
                            associatedValues.Add(value);
                            break;
                        case "SpecificFieldText":
                            SpecificFieldText = new SpecificFieldText_v2();
                            SpecificFieldText.ReadXml(reader);
                            break;
                    }
                }
                if (associatedValues.Count > 0) AssociatedValues = associatedValues.ToArray();
            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
