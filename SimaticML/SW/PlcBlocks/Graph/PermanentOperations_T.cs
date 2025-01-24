using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T : Object_G
    {
        public Common.Comment_T Title { get; set; }

        public Common.Comment_T Comment { get; set; }

        [XmlElement("PermanentOperation")]
        public PermanentOperation_T[] PermanentOperations { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var operations = new List<PermanentOperation_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T();
                            Comment.ReadXml(reader);
                            break;
                        case "PermanentOperation":
                            var operation = new PermanentOperation_T();
                            operation.ReadXml(reader);
                            operations.Add(operation);
                            break;
                    }
                }
                if (operations.Count > 0) PermanentOperations = operations.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v2 : PermanentOperations_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v2[] PermanentOperations { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var operations = new List<PermanentOperation_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "PermanentOperation":
                            var operation = new PermanentOperation_T_v2();
                            operation.ReadXml(reader);
                            operations.Add(operation);
                            break;
                    }
                }
                if (operations.Count > 0) PermanentOperations = operations.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v4 : PermanentOperations_T_v2
    {
        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v4[] PermanentOperations { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var operations = new List<PermanentOperation_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "PermanentOperation":
                            var operation = new PermanentOperation_T_v4();
                            operation.ReadXml(reader);
                            operations.Add(operation);
                            break;
                    }
                }
                if (operations.Count > 0) PermanentOperations = operations.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v5 : PermanentOperations_T_v4
    {
        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v5[] PermanentOperations { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var operations = new List<PermanentOperation_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "PermanentOperation":
                            var operation = new PermanentOperation_T_v5();
                            operation.ReadXml(reader);
                            operations.Add(operation);
                            break;
                    }
                }
                if (operations.Count > 0) PermanentOperations = operations.ToArray();

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
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v6 : PermanentOperations_T_v5
    {
        [XmlElement("PermanentOperation")]
        public new PermanentOperation_T_v6[] PermanentOperations { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var operations = new List<PermanentOperation_T_v6>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "PermanentOperation":
                            var operation = new PermanentOperation_T_v6();
                            operation.ReadXml(reader);
                            operations.Add(operation);
                            break;
                    }
                }
                if (operations.Count > 0) PermanentOperations = operations.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
