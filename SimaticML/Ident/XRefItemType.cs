using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class XRefItemType
    {
        public XRefItemType()
        {
            LineNo = 0;
            Instruction = 0;
            Name = "";
            XRefHidden = "false";
        }

        [XmlAttribute]
        public int UId { get; set; }

        [XmlAttribute]
        public string Usage { get; set; }

        [XmlAttribute]
        public int NetId { get; set; }
        [XmlIgnore()]
        public bool NetIdSpecified { get; set; }

        [XmlAttribute]
        [System.ComponentModel.DefaultValue(0)]
        public int LineNo { get; set; }

        [XmlAttribute]
        [System.ComponentModel.DefaultValue(0)]
        public int Instruction { get; set; }

        [XmlAttribute]
        [System.ComponentModel.DefaultValue("")]
        public string Name { get; set; }

        [XmlAttribute]
        [System.ComponentModel.DefaultValue("false")]
        public string XRefHidden { get; set; }
    }
}
