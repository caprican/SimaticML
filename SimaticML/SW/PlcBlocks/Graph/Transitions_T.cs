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
    [XmlRoot("Transitions", IsNullable = false)]
    public class Transitions_T : Object_G
    {
        [XmlElement("Transition")]
        private Transition_T[] Transition { get; set; }
        public Transition_T this[int key] { get => Transition[key]; set => Transition[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Transition_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Transition":
                            var transition = new Transition_T();
                            transition.ReadXml(reader);
                            items.Add(transition);
                            break;
                    }
                }
                if (items.Count > 0) Transition = items.ToArray();
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
    [XmlRoot("Transitions", IsNullable = false)]
    public class Transitions_T_v2 : Transitions_T
    {
        [XmlElement("Transition")]
        private Transition_T_v2[] Transition { get; set; }
        public new Transition_T_v2 this[int key] { get => Transition[key]; set => Transition[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Transition_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Transition":
                            var transition = new Transition_T_v2();
                            transition.ReadXml(reader);
                            items.Add(transition);
                            break;
                    }
                }
                if (items.Count > 0) Transition = items.ToArray();
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
    [XmlRoot("Transitions", IsNullable = false)]
    public class Transitions_T_v4 : Transitions_T_v2
    {
        [XmlElement("Transition")]
        private Transition_T_v4[] Transition { get; set; }
        public new Transition_T_v4 this[int key] { get => Transition[key]; set => Transition[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Transition_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Transition":
                            var transition = new Transition_T_v4();
                            transition.ReadXml(reader);
                            items.Add(transition);
                            break;
                    }
                }
                if (items.Count > 0) Transition = items.ToArray();
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
    [XmlRoot("Transitions", IsNullable = false)]
    public class Transitions_T_v5 : Transitions_T_v4
    {
        [XmlElement("Transition")]
        private Transition_T_v5[] Transition { get; set; }
        public new Transition_T_v5 this[int key] { get => Transition[key]; set => Transition[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Transition_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Transition":
                            var transition = new Transition_T_v5();
                            transition.ReadXml(reader);
                            items.Add(transition);
                            break;
                    }
                }
                if (items.Count > 0) Transition = items.ToArray();
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
    [XmlRoot("Transitions", IsNullable = false)]
    public class Transitions_T_v6 : Transitions_T_v5
    {
        [XmlElement("Transition")]
        private Transition_T_v6[] Transition { get; set; }
        public new Transition_T_v6 this[int key] { get => Transition[key]; set => Transition[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Transition_T_v6>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Transition":
                            var transition = new Transition_T_v6();
                            transition.ReadXml(reader);
                            items.Add(transition);
                            break;
                    }
                }
                if (items.Count > 0) Transition = items.ToArray();
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
