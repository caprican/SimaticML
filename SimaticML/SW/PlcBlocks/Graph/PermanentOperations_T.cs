using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IPermanentOperations_T : IEnumerable<IPermanentOperation_T>
    {
        Common.IComment_T Title { get; set; }
        Common.IComment_T Comment { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T : Object_G, IPermanentOperations_T
    {
        public Common.IComment_T Title { get; set; }

        public Common.IComment_T Comment { get; set; }

        [XmlElement("PermanentOperation")]
        protected internal IPermanentOperation_T[] PermanentOperations { get; set; }
        public IPermanentOperation_T this[int key] { get => PermanentOperations[key]; set => PermanentOperations[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var operations = new List<PermanentOperation_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "PermanentOperation":
                            var operation = new PermanentOperation_T();
                            operation.ReadXml(reader);
                            operations.Add(operation);
                            break;
                    }
                }
                if (operations.Count > 0) PermanentOperations = operations.ToArray();
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

        public IEnumerator<IPermanentOperation_T> GetEnumerator()
        {
            if (PermanentOperations is null) yield break;
            foreach (var operation in PermanentOperations)
            {
                yield return operation;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v2 : PermanentOperations_T, IPermanentOperations_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        //[XmlElement("PermanentOperation")]
        //protected internal new PermanentOperation_T_v2[] PermanentOperations { get; set; }
        //public new PermanentOperation_T_v2 this[int key] { get => PermanentOperations[key]; set => PermanentOperations[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
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

        //public new IEnumerator<PermanentOperation_T_v2> GetEnumerator()
        //{
        //    foreach (var item in PermanentOperations)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v4 : PermanentOperations_T_v2, IPermanentOperations_T
    {
        //[XmlElement("PermanentOperation")]
        //protected internal new PermanentOperation_T_v4[] PermanentOperations { get; set; }
        //public new PermanentOperation_T_v4 this[int key] { get => PermanentOperations[key]; set => PermanentOperations[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
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

        //public new IEnumerator<PermanentOperation_T_v4> GetEnumerator()
        //{
        //    foreach (var item in PermanentOperations)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v5 : PermanentOperations_T_v4, IPermanentOperations_T
    {
        //[XmlElement("PermanentOperation")]
        //protected internal new PermanentOperation_T_v5[] PermanentOperations { get; set; }
        //public new PermanentOperation_T_v5 this[int key] { get => PermanentOperations[key]; set => PermanentOperations[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
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

        //public new IEnumerator<PermanentOperation_T_v5> GetEnumerator()
        //{
        //    foreach (var item in PermanentOperations)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("PostOperations", IsNullable = false)]
    public class PermanentOperations_T_v6 : PermanentOperations_T_v5, IPermanentOperations_T
    {
        //[XmlElement("PermanentOperation")]
        //protected internal new PermanentOperation_T_v6[] PermanentOperations { get; set; }
        //public new PermanentOperation_T_v6 this[int key] { get => PermanentOperations[key]; set => PermanentOperations[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
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

        //public new IEnumerator<PermanentOperation_T_v6> GetEnumerator()
        //{
        //    foreach (var item in PermanentOperations)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
