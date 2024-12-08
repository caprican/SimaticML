using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
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

        /// <remarks>Add on v2</remarks>
        [XmlElement("BooleanAttribute")]
        public BooleanAttribute_T[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
