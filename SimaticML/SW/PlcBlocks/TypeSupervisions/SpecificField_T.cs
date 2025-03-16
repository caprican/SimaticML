using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    public interface ISpecificField
    {
        IAssociatedValue[] AssociatedValues { get; set; }

        ISpecificFieldText SpecificFieldText { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class SpecificField_T : Object_G, ISpecificField
    {
        [XmlArrayItem("AssociatedValue", IsNullable = false)]
        public IAssociatedValue[] AssociatedValues { get; set; }

        public ISpecificFieldText SpecificFieldText { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var associatedValues = new List<IAssociatedValue>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AssociatedValue":
                            var value = new AssociatedValue_T();
                            value.ReadXml(reader);
                            associatedValues.Add(value);
                            break;
                        case nameof(SpecificFieldText) :
                            var specificFieldText = new SpecificFieldText_T();
                            specificFieldText.ReadXml(reader);
                            SpecificFieldText = specificFieldText;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (associatedValues.Count > 0) AssociatedValues = associatedValues.ToArray();
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
    /// Schema : SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class SpecificField_T_v2 : SpecificField_T, ISpecificField
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var associatedValues = new List<IAssociatedValue>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AssociatedValue":
                            var value = new AssociatedValue_T();
                            value.ReadXml(reader);
                            associatedValues.Add(value);
                            break;
                        case nameof(SpecificFieldText) :
                            var specificFieldText = new SpecificFieldText_T_v2();
                            specificFieldText.ReadXml(reader);
                            SpecificFieldText = specificFieldText;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (associatedValues.Count > 0) AssociatedValues = associatedValues.ToArray();
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
