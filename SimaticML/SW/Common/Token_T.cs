using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    public interface IToken
    {
        IIntegerAttribute IntegerAttribute { get; set; }
        int? UId { get; set; }
        string Text { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Token", IsNullable = false)]
    public class Token_T : Object_G, IToken
    {
        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces at the start.
        /// This is informative.
        /// </summary>
        public IIntegerAttribute IntegerAttribute { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public string Text { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Text):
                        Text = reader.ReadContentAsString();
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(IntegerAttribute):
                            var integerAttribute = new Common.IntegerAttribute_T();
                            integerAttribute.ReadXml(reader);
                            IntegerAttribute = integerAttribute;
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }

                reader.ReadEndElement();
            }
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
    [XmlRoot("Token", IsNullable = false)]
    public class Token_T_v2 : Token_T, IToken
    {
        ///// <summary>
        ///// For NumBLs. NumBLs is the count of the blank spaces at the start.
        ///// This is informative.
        ///// </summary>

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Text):
                        Text = reader.ReadContentAsString();
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(IntegerAttribute):
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            IntegerAttribute = integerAttribute;
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
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
