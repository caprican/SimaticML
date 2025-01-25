using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using SimaticML.SW.PlcBlocks.Graph;

namespace SimaticML.SW.PlcBlocks.STL
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlToken", IsNullable = false)]
    public class StlToken_T : Object_G
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public Common.IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        public Object_G[] Items { get; set; }

        /// <summary>
        /// e.g 0 1 for NOP 0, NOP 1; STW for L STW or DILG for L DILG; only if separated by comment
        /// </summary>
        public Common.Token_T Token { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public STL_TE Text { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<STL_TE>(reader.GetAttribute("Text"), out var text);
            Text = text;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "Token":
                            Token = new Common.Token_T_v2();
                            Token.ReadXml(reader);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlToken", IsNullable = false)]
    public class StlToken_T_v2 : StlToken_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public new Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Object_G[] Items { get; set; }

        /// <summary>
        /// e.g 0 1 for NOP 0, NOP 1; STW for L STW or DILG for L DILG; only if separated by comment
        /// </summary>
        public new Common.Token_T_v2 Token { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<STL_TE>(reader.GetAttribute("Text"), out var text);
            Text = text;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v2();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;

                        case "Token":
                            Token = new Common.Token_T_v2();
                            Token.ReadXml(reader);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    ///          SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlToken", IsNullable = false)]
    public class StlToken_T_v4 : StlToken_T_v2
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public new Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<STL_TE>(reader.GetAttribute("Text"), out var text);
            Text = text;

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v3();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;

                        case "Token":
                            Token = new Common.Token_T_v2();
                            Token.ReadXml(reader);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
