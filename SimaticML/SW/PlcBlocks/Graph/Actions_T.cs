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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T : Object_G
    {
        public Common.Comment_T Title { get; set; }

        [XmlElement("Action")]
        public Action_T[] Actions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T();
                            Title.ReadXml(reader);
                            break;
                        case "Action":
                            var action = new Action_T();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();

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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v2 : Actions_T
    {
        public new Common.Comment_T_v2 Title { get; set; }

        [XmlElement("Action")]
        public new Action_T_v2[] Actions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Action":
                            var action = new Action_T_v2();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();

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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v4 : Actions_T_v2
    {
        [XmlElement("Action")]
        public new Action_T_v4[] Actions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Action":
                            var action = new Action_T_v4();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();

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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v5 : Actions_T_v4
    {
        [XmlElement("Action")]
        public new Action_T_v5[] Actions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Action":
                            var action = new Action_T_v5();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();

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
    [XmlRoot("Actions", IsNullable = false)]
    public class Actions_T_v6 : Actions_T_v5
    {
        [XmlElement("Action")]
        public new Action_T_v6[] Actions { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var actions = new List<Action_T_v6>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Title":
                            Title = new Common.Comment_T_v2();
                            Title.ReadXml(reader);
                            break;
                        case "Action":
                            var action = new Action_T_v6();
                            action.ReadXml(reader);
                            actions.Add(action);
                            break;
                    }
                }
                if (actions.Count > 0) Actions = actions.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
