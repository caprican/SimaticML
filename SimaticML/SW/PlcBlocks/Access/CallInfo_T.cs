using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    [Serializable]
    public class CallInfo_T
    {
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("DateAttribute", typeof(DateAttribute_T))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        [XmlElement("Instance", typeof(Instance_T))]
        [XmlElement("IntegerAttribute", typeof(IntegerAttribute_T))]          // for BlockNumber. BlockNumber is informative.
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public BlockType_TE BlockType { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
