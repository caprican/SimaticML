using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("Constant", Namespace = "", IsNullable = false)]
    public class Constant_T
    {
        public ConstantType ConstantType { get; set; }

        public ConstantValue ConstantValue { get; set; }

        /// <summary>
        /// for Format and FormatFlags. They are informative..
        /// </summary>
        [XmlElement("StringAttribute")]
        public StringAttribute_T[] StringAttribute { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        /// <remarks>Add on v2</remarks>
        [XmlElement("BooleanAttribute")]
        public BooleanAttribute_T[] BooleanAttribute { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
