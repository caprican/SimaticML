using System;
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
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T : Object_G
    {
        public Common.Comment_T Title { get; set; }

        public Common.Comment_T Comment { get; set; }

        public Steps_T Steps { get; set; }

        public Transitions_T Transitions { get; set; }

        public Branches_T Branches { get; set; }

        public Connections_T Connections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

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
                        case "Steps":
                            Steps = new Steps_T();
                            Steps.ReadXml(reader);
                            break;
                        case "Transitions":
                            Transitions = new Transitions_T();
                            Transitions.ReadXml(reader);
                            break;
                        case "Branches":
                            Branches = new Branches_T();
                            Branches.ReadXml(reader);
                            break;
                        case "Connections":
                            Connections = new Connections_T();
                            Connections.ReadXml(reader);
                            break;
                    }
                }
            }
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
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v2 : Sequence_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        public new Steps_T_v2 Steps { get; set; }

        public new Transitions_T_v2 Transitions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

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
                        case "Steps":
                            Steps = new Steps_T_v2();
                            Steps.ReadXml(reader);
                            break;
                        case "Transitions":
                            Transitions = new Transitions_T_v2();
                            Transitions.ReadXml(reader);
                            break;
                        case "Branches":
                            Branches = new Branches_T();
                            Branches.ReadXml(reader);
                            break;
                        case "Connections":
                            Connections = new Connections_T();
                            Connections.ReadXml(reader);
                            break;
                    }
                }
            }
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
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v4 : Sequence_T_v2
    {
        public new Steps_T_v4 Steps { get; set; }

        public new Transitions_T_v4 Transitions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

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
                        case "Steps":
                            Steps = new Steps_T_v4();
                            Steps.ReadXml(reader);
                            break;
                        case "Transitions":
                            Transitions = new Transitions_T_v4();
                            Transitions.ReadXml(reader);
                            break;
                        case "Branches":
                            Branches = new Branches_T();
                            Branches.ReadXml(reader);
                            break;
                        case "Connections":
                            Connections = new Connections_T();
                            Connections.ReadXml(reader);
                            break;
                    }
                }
            }
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
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v5 : Sequence_T_v4
    {
        public new Steps_T_v5 Steps { get; set; }

        public new Transitions_T_v5 Transitions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

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
                        case "Steps":
                            Steps = new Steps_T_v5();
                            Steps.ReadXml(reader);
                            break;
                        case "Transitions":
                            Transitions = new Transitions_T_v5();
                            Transitions.ReadXml(reader);
                            break;
                        case "Branches":
                            Branches = new Branches_T();
                            Branches.ReadXml(reader);
                            break;
                        case "Connections":
                            Connections = new Connections_T();
                            Connections.ReadXml(reader);
                            break;
                    }
                }
            }
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
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v6 : Sequence_T_v5
    {
        public new Steps_T_v6 Steps { get; set; }


        public new Transitions_T_v6 Transitions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

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
                        case "Steps":
                            Steps = new Steps_T_v6();
                            Steps.ReadXml(reader);
                            break;
                        case "Transitions":
                            Transitions = new Transitions_T_v6();
                            Transitions.ReadXml(reader);
                            break;
                        case "Branches":
                            Branches = new Branches_T();
                            Branches.ReadXml(reader);
                            break;
                        case "Connections":
                            Connections = new Connections_T();
                            Connections.ReadXml(reader);
                            break;
                    }
                }
            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
