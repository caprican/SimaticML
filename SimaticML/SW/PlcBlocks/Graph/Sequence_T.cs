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
    [XmlRoot("Sequence", IsNullable = false)]
    public class Sequence_T : Object_G
    {
        public Common.Comment_T Title { get; set; }

        public Common.Comment_T Comment { get; set; }

        [XmlArray("Steps")]
        [XmlArrayItem("Step", typeof(Step_T))]
        public Step_T[] Steps { get; set; }

        [XmlArray("Transitions")]
        [XmlArrayItem("Transition", typeof(Transition_T))]
        public Transition_T[] Transitions { get; set; }

        [XmlArray("Branches")]
        [XmlArrayItem("Branch", typeof(Branch_T))]
        public Branch_T[] Branches { get; set; }

        [XmlArray("Connections")]
        [XmlArrayItem("Connection", typeof(Connection_T))]
        public Connection_T[] Connections { get; set; }

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
                            Title = new Common.Comment_T();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T();
                            Comment.ReadXml(reader);
                            break;
                        case "Steps":
                            var steps = new List<Step_T>();
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
                            break;
                        case "Transitions":
                            var transitions = new List<Transition_T>();
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
                            break;
                        case "Branches":
                            var branches = new List<Branch_T>();
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
                            break;
                        case "Connections":
                            var connections = new List<Connection_T>();
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
    public class Sequence_T_v2 : Sequence_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        [XmlArray("Steps")]
        [XmlArrayItem("Step", typeof(Step_T_v2))]
        public new Step_T_v2[] Steps { get; set; }

        [XmlArray("Transitions")]
        [XmlArrayItem("Transition", typeof(Transition_T_v2))]
        public new Transition_T_v2[] Transitions { get; set; }

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
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Steps":
                            var steps = new List<Step_T_v2>();
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
                            break;
                        case "Transitions":
                            var transitions = new List<Transition_T_v2>();
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
                            break;
                        case "Branches":
                            var branches = new List<Branch_T>();
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
                            break;
                        case "Connections":
                            var connections = new List<Connection_T>();
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
    public class Sequence_T_v4 : Sequence_T_v2
    {
        [XmlArray("Steps")]
        [XmlArrayItem("Step", typeof(Step_T_v4))]
        public new Step_T_v4[] Steps { get; set; }

        [XmlArray("Transitions")]
        [XmlArrayItem("Transition", typeof(Transition_T_v4))]
        public new Transition_T_v4[] Transitions { get; set; }

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
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Steps":
                            var steps = new List<Step_T_v4>();
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
                            break;
                        case "Transitions":
                            var transitions = new List<Transition_T_v4>();
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
                            break;
                        case "Branches":
                            var branches = new List<Branch_T>();
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
                            break;
                        case "Connections":
                            var connections = new List<Connection_T>();
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
    public class Sequence_T_v5 : Sequence_T_v4
    {
        [XmlArray("Steps")]
        [XmlArrayItem("Step", typeof(Step_T_v5))]
        public new Step_T_v5[] Steps { get; set; }

        [XmlArray("Transitions")]
        [XmlArrayItem("Transition", typeof(Transition_T_v5))]
        public new Transition_T_v5[] Transitions { get; set; }

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
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Steps":
                            var steps = new List<Step_T_v5>();
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
                            break;
                        case "Transitions":
                            var transitions = new List<Transition_T_v5>();
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
                            break;
                        case "Branches":
                            var branches = new List<Branch_T>();
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
                            break;
                        case "Connections":
                            var connections = new List<Connection_T>();
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
    public class Sequence_T_v6 : Sequence_T_v5
    {
        [XmlArray("Steps")]
        [XmlArrayItem("Step", typeof(Step_T_v5))]
        public new Step_T_v6[] Steps { get; set; }

        [XmlArray("Transitions")]
        [XmlArrayItem("Transition", typeof(Transition_T_v6))]
        public new Transition_T_v6[] Transitions { get; set; }

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
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Steps":
                            var steps = new List<Step_T_v6>();
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
                            break;
                        case "Transitions":
                            var transitions = new List<Transition_T_v6>();
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
                            break;
                        case "Branches":
                            var branches = new List<Branch_T>();
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
                            break;
                        case "Connections":
                            var connections = new List<Connection_T>();
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
