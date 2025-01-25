using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    ///          SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class ConditionOperand : Object_G
    {
        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("Number"), out var number);
            Number = number;

            Name = reader.GetAttribute("Name");
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
