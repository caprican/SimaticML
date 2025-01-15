using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Address", Namespace="", IsNullable=false)]
    public class Address_T
    {
        public Address_T()
        {
            Informative = false;
        }

        [XmlAttribute]
        public Area_TE Area { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        /// <summary>
        /// for DB access
        /// </summary>
        [XmlAttribute]
        public int BlockNumber { get; set; }
        [XmlIgnore]
        public bool BlockNumberSpecified { get; set; }

        /// <summary>
        /// In general it is Byte * 8 + Bit. But if it is used for addressing a DB we will find the number of the DB here (e.g. "DB12" ->12).
        /// </summary>
        [XmlAttribute]
        public int BitOffset { get; set; }
        [XmlIgnore]
        public bool BitOffsetSpecified { get; set; }

        /// <summary>
        /// if true, the import unnoted it
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Address", Namespace = "", IsNullable = false)]
    public class Address_T_v2 : Address_T
    {
        [XmlElement("BooleanAttribute")]
        public Common.BooleanAttribute_T_v2[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
