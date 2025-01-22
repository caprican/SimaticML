using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("ViewInfo", IsNullable = false)]
    public class ViewInfo_T : Object_G
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
            StartSpecified = bool.TryParse(reader.GetAttribute("Start"), out var start);
            if (StartSpecified) Start = start;

            XPosSpecified = int.TryParse(reader.GetAttribute("XPos"), out var xPos);
            if (XPosSpecified) XPos = xPos;

            YPosSpecified = int.TryParse(reader.GetAttribute("YPos"), out var yPos);
            if (YPosSpecified) YPos = yPos;

            WidthSpecified = int.TryParse(reader.GetAttribute("Width"), out var width);
            if (WidthSpecified) Width = width;

            HeightSpecified = int.TryParse(reader.GetAttribute("Height"), out var height);
            if (HeightSpecified) Height = height;

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            
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
    public class ViewInfo_T_v2 : ViewInfo_T
    {
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            StartSpecified = bool.TryParse(reader.GetAttribute("Start"), out var start);
            if (StartSpecified) Start = start;

            XPosSpecified = int.TryParse(reader.GetAttribute("XPos"), out var xPos);
            if (XPosSpecified) XPos = xPos;

            YPosSpecified = int.TryParse(reader.GetAttribute("YPos"), out var yPos);
            if (YPosSpecified) YPos = yPos;

            WidthSpecified = int.TryParse(reader.GetAttribute("Width"), out var width);
            if (WidthSpecified) Width = width;

            HeightSpecified = int.TryParse(reader.GetAttribute("Height"), out var height);
            if (HeightSpecified) Height = height;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {

        }
    }
}
