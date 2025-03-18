using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    public interface IViewInfo
    {
        bool? Start { get; set; }
        int? XPos { get; set; }
        int? YPos { get; set; }
        int? Width { get; set; }
        int? Height { get; set; }
    }

    public interface IViewInfo_v2 : IViewInfo
    {
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("ViewInfo", IsNullable = false)]
    public class ViewInfo_T : Object_G, IViewInfo
    {
        [XmlAttribute]
        public bool? Start { get; set; } = null;
        [XmlIgnore]
        public bool StartSpecified { get; set; }

        [XmlAttribute]
        public int? XPos { get; set; } = null;
        [XmlIgnore]
        public bool XPosSpecified { get; set; }

        [XmlAttribute]
        public int? YPos { get; set; } = null;
        [XmlIgnore]
        public bool YPosSpecified { get; set; }

        [XmlAttribute]
        public int? Width { get; set; } = null;
        [XmlIgnore]
        public bool WidthSpecified { get; set; }

        [XmlAttribute]
        public int? Height { get; set; } = null;
        [XmlIgnore]
        public bool HeightSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Start):
                        Start = reader.ReadContentAsBoolean();
                        StartSpecified = true;
                        break;
                    case nameof(XPos):
                        XPos = reader.ReadContentAsInt();
                        XPosSpecified = true;
                        break;
                    case nameof(YPos):
                        YPos = reader.ReadContentAsInt();
                        YPosSpecified = true;
                        break;
                    case nameof(Width):
                        Width = reader.ReadContentAsInt();
                        WidthSpecified = true;
                        break;
                    case nameof(Height):
                        Height = reader.ReadContentAsInt();
                        HeightSpecified = true;
                        break;

                    default:
                        break;
                }
            }

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("ViewInfo", IsNullable = false)]
    public class ViewInfo_T_v2 : ViewInfo_T, IViewInfo_v2
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
                    case nameof(Start):
                        Start = reader.ReadContentAsBoolean();
                        StartSpecified = true;
                        break;
                    case nameof(XPos):
                        XPos = reader.ReadContentAsInt();
                        XPosSpecified = true;
                        break;
                    case nameof(YPos):
                        YPos = reader.ReadContentAsInt();
                        YPosSpecified = true;
                        break;
                    case nameof(Width):
                        Width = reader.ReadContentAsInt();
                        WidthSpecified = true;
                        break;
                    case nameof(Height):
                        Height = reader.ReadContentAsInt();
                        HeightSpecified = true;
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;

                    default:
                        break;
                }
            }

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
