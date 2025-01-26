using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    [XmlRoot("Comment", IsNullable = false)]
    public class Comment_T : Comment_G
    {
        /// <summary>
        /// Denotes if the comment is at the end of the line (using //) or inside the line (using /* */)
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Inserted { get; set; } = false;

        /// <summary>
        /// Exported only with ReadOnly option, ignored during import.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces before the actual text in the Comment.
        /// This is informative.
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("MultiLanguageText")]
        public MultiLanguageText_T[] MultiLanguageTexts { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Inserted):
                        Inserted = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var texts = new List<MultiLanguageText_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "MultiLanguageText":
                            MultiLanguageText_T text = new MultiLanguageText_T();
                            text.ReadXml(reader);
                            texts.Add(text);
                            break;
                        case "IntegerAttribute":
                            IntegerAttribute = new IntegerAttribute_T();
                            IntegerAttribute.ReadXml(reader);
                            break;
                    }
                }
                if (texts.Count > 0) MultiLanguageTexts = texts.ToArray();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Comment", IsNullable = false)]
    public class Comment_T_v2 : Comment_T
    {
        /// <summary>
        /// For NumBLs. NumBLs is the count of the blank spaces before the actual text in the Comment.
        /// This is informative.
        /// </summary>
        public new IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("MultiLanguageText")]
        public new MultiLanguageText_T_v2[] MultiLanguageTexts { get; set; }

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
                    case nameof(Inserted):
                        Inserted = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
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

                var multiLanguageTests = new List<MultiLanguageText_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch(reader.Name)
                    {
                        case "MultiLanguageText":
                            MultiLanguageText_T_v2 num = new MultiLanguageText_T_v2();
                            num.ReadXml(reader);
                            multiLanguageTests.Add(num);
                            break;
                        case "IntegerAttribute" :
                            IntegerAttribute = new IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                    }
                }
                if(multiLanguageTests.Count > 0) MultiLanguageTexts = multiLanguageTests.ToArray();
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
