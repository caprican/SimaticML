using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    public interface IBlank_T : IComment
    {
        uint Num { get; set; }
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    ///<item>SW_Common_v2</item>
    ///<item>SW_Common_v3</item>
    ///</list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Blank", IsNullable = false)]
    public class Blank_T : Comment_G, IBlank_T
    {
        [XmlAttribute(DataType = "positiveInteger")]
        [DefaultValue("1")]
        public uint Num { get; set; } = 1;

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
                    case nameof(Num):
                        Num = (uint)reader.ReadContentAsInt();
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
