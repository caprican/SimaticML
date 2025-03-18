using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    public interface IAssociatedValues
    {
        IAssociatedValue[] AssociatedValue { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    ///          SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class AssociatedValues_T : Object_G, IAssociatedValues
    {
        [XmlElement("AssociatedValue")]
        public IAssociatedValue[] AssociatedValue { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
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
                            var associatedValue = new AssociatedValue_T();
                            associatedValue.ReadXml(reader);
                            associatedValues.Add(associatedValue);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if(associatedValues.Count > 0) AssociatedValue = associatedValues.ToArray();
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
