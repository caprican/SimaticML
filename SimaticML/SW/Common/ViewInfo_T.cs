using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    [Serializable]
    //[XmlRoot("ViewInfo", Namespace = "", IsNullable = false)]
    public class ViewInfo_T
    {
        [XmlAttribute]
        public bool Start { get; set; }
        [XmlIgnore]
        public bool StartSpecified { get; set; }

        [XmlAttribute]
        public int XPos { get; set; }
        [XmlIgnore]
        public bool XPosSpecified { get; set; }

        [XmlAttribute]
        public int YPos { get; set; }
        [XmlIgnore]
        public bool YPosSpecified { get; set; }

        [XmlAttribute]
        public int Width { get; set; }
        [XmlIgnore]
        public bool WidthSpecified { get; set; }

        [XmlAttribute]
        public int Height { get; set; }
        [XmlIgnore]
        public bool HeightSpecified { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
