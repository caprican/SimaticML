﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IActions_T : IEnumerable<Object_G>
    {
        Common.IComment_T Title { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T : Object_G, IActions_T
    {
        public Common.IComment_T Title { get; set; }

        [XmlElement("Action")]
        protected internal Action_T[] Actions { get; set; }
        public Action_T this[int key] { get => Actions[key]; set => Actions[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Action":
                            var action = new Action_T();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();
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

        public IEnumerator<Object_G> GetEnumerator()
        {
            if (Actions is null) yield break; 
            foreach (var action in Actions)
            {
                yield return action;
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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v2 : Actions_T, IActions_T
    {
        //public new Common.Comment_T_v2 Title { get; set; }

        //[XmlElement("Action")]
        //protected internal new Action_T_v2[] Actions { get; set; }
        //public new Action_T_v2 this[int key] { get => Actions[key]; set => Actions[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Action":
                            var action = new Action_T_v2();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();
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

        //public new IEnumerator<Action_T_v2> GetEnumerator()
        //{
        //    foreach (var item in Actions)
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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v4 : Actions_T_v2, IActions_T
    {
        //[XmlElement("Action")]
        //protected internal new Action_T_v4[] Actions { get; set; }
        //public new Action_T_v4 this[int key] { get => Actions[key]; set => Actions[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Action":
                            var action = new Action_T_v4();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();
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

        //public new IEnumerator<Action_T_v4> GetEnumerator()
        //{
        //    foreach (var item in Actions)
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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v5 : Actions_T_v4, IActions_T
    {
        //[XmlElement("Action")]
        //protected internal new Action_T_v5[] Actions { get; set; }
        //public new Action_T_v5 this[int key] { get => Actions[key]; set => Actions[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Action":
                            var action = new Action_T_v5();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();
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

        //public new IEnumerator<Action_T_v5> GetEnumerator()
        //{
        //    foreach (var item in Actions)
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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v6 : Actions_T_v5, IActions_T
    {
        //[XmlElement("Action")]
        //protected internal new Action_T_v6[] Actions { get; set; }
        //public new Action_T_v6 this[int key] { get => Actions[key]; set => Actions[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v6>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            var title = new Common.Comment_T_v2();
                            title.ReadXml(reader);
                            Title = title;
                            break;
                        case "Action":
                            var action = new Action_T_v6();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();
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

        //public new IEnumerator<Action_T_v6> GetEnumerator()
        //{
        //    foreach (var item in Actions)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
