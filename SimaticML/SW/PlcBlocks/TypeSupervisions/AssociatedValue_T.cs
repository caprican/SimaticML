using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    public interface IAssociatedValue
    {
        IAssociatedValueOperand AssociatedValueOperand { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    ///          SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class AssociatedValue_T : Object_G, IAssociatedValue
    {
        public IAssociatedValueOperand AssociatedValueOperand { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AssociatedValueOperand":
                            var associatedValueOperand  = new AssociatedValueOperand_T();
                            associatedValueOperand.ReadXml(reader);
                            AssociatedValueOperand = associatedValueOperand;
                            break;
                    }
                }

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
