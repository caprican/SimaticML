using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    public interface IDelayOperand
    {
        string Name { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    ///          SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DelayOperand_T : Object_G, IDelayOperand
    {
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
