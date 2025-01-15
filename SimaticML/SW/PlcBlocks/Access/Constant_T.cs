using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Constant", Namespace = "", IsNullable = false)]
    public class Constant_T
    {
        public ConstantType_T ConstantType { get; set; }

        public ConstantValue_T ConstantValue { get; set; }

        /// <summary>
        /// for Format and FormatFlags. They are informative..
        /// </summary>
        [XmlElement("StringAttribute")]
        public Common.StringAttribute_T[] StringAttribute { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Constant", Namespace = "", IsNullable = false)]
    public class Constant_T_v2 : Constant_T
    {
        public new ConstantType_T_v2 ConstantType { get; set; }

        public new ConstantValue_T_v2 ConstantValue { get; set; }

        /// <summary>
        /// for Format and FormatFlags. They are informative..
        /// </summary>
        [XmlElement("StringAttribute")]
        public new Common.StringAttribute_T_v2[] StringAttribute { get; set; }

        [XmlElement("BooleanAttribute")]
        public Common.BooleanAttribute_T_v2[] BooleanAttribute { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
