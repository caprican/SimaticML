﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IConstantType
    {
        bool? Informative { get; set; }
        string Value { get; set; }
    }

    public interface IConstantType_v2 : IConstantType
    {
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "ConstantType", IsNullable = false)]
    public class ConstantType_T : Object_G, IConstantType
    {
        [XmlAttribute]
        public bool? Informative { get; set; } = null;
        [XmlIgnore]
        public bool InformativeSpecified { get; set; }

        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        InformativeSpecified = true;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadInnerXml();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "ConstantType", IsNullable = false)]
    public class ConstantType_T_v2 : ConstantType_T, IConstantType_v2
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        InformativeSpecified = true;
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            Value = reader.ReadInnerXml();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
