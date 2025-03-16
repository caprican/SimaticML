using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface ISequence
    {
        Common.IComment_T Title { get; set; }
        Common.IComment_T Comment { get; set; }
        IStep[] Steps { get; set; }
        ITransition[] Transitions { get; set; }
        IBranch[] Branches { get; set; }
        IConnection[] Connections { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T : Object_G, ISequence
    {
        public Common.IComment_T Title { get; set; }

        public Common.IComment_T Comment { get; set; }

        [XmlArray("Steps")]
        [XmlArrayItem("Step", typeof(Step_T))]
        public IStep[] Steps { get; set; }

        [XmlArray("Transitions")]
        [XmlArrayItem("Transition", typeof(Transition_T))]
        public ITransition[] Transitions { get; set; }

        [XmlArray("Branches")]
        [XmlArrayItem("Branch", typeof(Branch_T))]
        public IBranch[] Branches { get; set; }

        [XmlArray("Connections")]
        [XmlArrayItem("Connection", typeof(Connection_T))]
        public IConnection[] Connections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

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
                        case "Steps":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var steps = new List<IStep>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Step":
                                            var step = new Step_T();
                                            step.ReadXml(reader);
                                            steps.Add(step);
                                            break;
                                    }
                                }
                                if (steps.Count > 0) Steps = steps.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Transitions":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var transitions = new List<ITransition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Transition":
                                            var transition = new Transition_T();
                                            transition.ReadXml(reader);
                                            transitions.Add(transition);
                                            break;
                                    }
                                }
                                if (transitions.Count > 0) Transitions = transitions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Branches":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var branches = new List<IBranch>();
                                while (reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Branch":
                                            var branch = new Branch_T();
                                            branch.ReadXml(reader);
                                            branches.Add(branch);
                                            break;
                                    }
                                }
                                if (branches.Count == 0) Branches = branches.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Connections":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var connections = new List<IConnection>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Connection":
                                            var connexion = new Connection_T();
                                            connexion.ReadXml(reader);
                                            connections.Add(connexion);
                                            break;
                                    }
                                }
                                if (connections.Count > 0) Connections = connections.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v2 : Sequence_T, ISequence
    {
        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "Steps":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var steps = new List<IStep_v2>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Step":
                                            var step = new Step_T_v2();
                                            step.ReadXml(reader);
                                            steps.Add(step);
                                            break;
                                    }
                                }
                                if (steps.Count > 0) Steps = steps.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Transitions":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var transitions = new List<ITransition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Transition":
                                            var transition = new Transition_T_v2();
                                            transition.ReadXml(reader);
                                            transitions.Add(transition);
                                            break;
                                    }
                                }
                                if (transitions.Count > 0) Transitions = transitions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Branches":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var branches = new List<IBranch>();
                                while (reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Branch":
                                            var branch = new Branch_T();
                                            branch.ReadXml(reader);
                                            branches.Add(branch);
                                            break;
                                    }
                                }
                                if (branches.Count == 0) Branches = branches.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Connections":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var connections = new List<IConnection>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Connection":
                                            var connexion = new Connection_T();
                                            connexion.ReadXml(reader);
                                            connections.Add(connexion);
                                            break;
                                    }
                                }
                                if (connections.Count > 0) Connections = connections.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v4 : Sequence_T_v2, ISequence
    {
        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "Steps":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var steps = new List<IStep_v2>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Step":
                                            var step = new Step_T_v4();
                                            step.ReadXml(reader);
                                            steps.Add(step);
                                            break;
                                    }
                                }
                                if (steps.Count > 0) Steps = steps.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Transitions":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var transitions = new List<ITransition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Transition":
                                            var transition = new Transition_T_v4();
                                            transition.ReadXml(reader);
                                            transitions.Add(transition);
                                            break;
                                    }
                                }
                                if (transitions.Count > 0) Transitions = transitions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Branches":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var branches = new List<IBranch>();
                                while (reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Branch":
                                            var branch = new Branch_T();
                                            branch.ReadXml(reader);
                                            branches.Add(branch);
                                            break;
                                    }
                                }
                                if (branches.Count == 0) Branches = branches.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Connections":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var connections = new List<IConnection>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Connection":
                                            var connexion = new Connection_T();
                                            connexion.ReadXml(reader);
                                            connections.Add(connexion);
                                            break;
                                    }
                                }
                                if (connections.Count > 0) Connections = connections.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v5 : Sequence_T_v4, ISequence
    {
        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "Steps":
                            reader.MoveToContent();

                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var steps = new List<IStep_v2>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Step":
                                            var step = new Step_T_v5();
                                            step.ReadXml(reader);
                                            steps.Add(step);
                                            break;
                                    }
                                }
                                if (steps.Count > 0) Steps = steps.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Transitions":
                            reader.MoveToContent();

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var transitions = new List<ITransition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Transition":
                                            var transition = new Transition_T_v5();
                                            transition.ReadXml(reader);
                                            transitions.Add(transition);
                                            break;
                                    }
                                }
                                if (transitions.Count > 0) Transitions = transitions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Branches":
                            reader.MoveToContent();

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var branches = new List<IBranch>();
                                while (reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Branch":
                                            var branch = new Branch_T();
                                            branch.ReadXml(reader);
                                            branches.Add(branch);
                                            break;
                                    }
                                }
                                if (branches.Count == 0) Branches = branches.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Connections":
                            reader.MoveToContent();

                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var connections = new List<IConnection>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Connection":
                                            var connexion = new Connection_T();
                                            connexion.ReadXml(reader);
                                            connections.Add(connexion);
                                            break;
                                    }
                                }
                                if (connections.Count > 0) Connections = connections.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T_v6 : Sequence_T_v5, ISequence
    {
        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "Steps":
                            reader.MoveToContent();

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var steps = new List<IStep_v2>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Step":
                                            var step = new Step_T_v6();
                                            step.ReadXml(reader);
                                            steps.Add(step);
                                            break;
                                    }
                                }
                                if (steps.Count > 0) Steps = steps.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Transitions":
                            reader.MoveToContent();

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var transitions = new List<ITransition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Transition":
                                            var transition = new Transition_T_v6();
                                            transition.ReadXml(reader);
                                            transitions.Add(transition);
                                            break;
                                    }
                                }
                                if (transitions.Count > 0) Transitions = transitions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Branches":
                            reader.MoveToContent();

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var branches = new List<IBranch>();
                                while (reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Branch":
                                            var branch = new Branch_T();
                                            branch.ReadXml(reader);
                                            branches.Add(branch);
                                            break;
                                    }
                                }
                                if (branches.Count == 0) Branches = branches.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Connections":
                            reader.MoveToContent();

                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var connections = new List<IConnection>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Connection":
                                            var connexion = new Connection_T();
                                            connexion.ReadXml(reader);
                                            connections.Add(connexion);
                                            break;
                                    }
                                }
                                if (connections.Count > 0) Connections = connections.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
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
