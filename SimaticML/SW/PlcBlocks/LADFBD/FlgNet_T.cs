using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    public interface IFlgNet_T : IEnumerable<Object_G>
    {

    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    internal class FlgNet_T : Object_G, IFlgNet_T
    {
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Labels":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();
                                
                                var labels = new List<CompileUnitCommon.LabelDeclaration_T>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "LabelDeclaration":
                                            var label = new CompileUnitCommon.LabelDeclaration_T();
                                            label.ReadXml(reader);
                                            labels.Add(label);
                                            break;
                                    }
                                }
                                if (labels.Count > 0) items.AddRange(labels);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Access":
                            var access = new Access.Access_T();
                            access.ReadXml(reader);
                            items.Add(access);
                            break;
                        case "Call":
                            var call = new Call_T();
                            call.ReadXml(reader);
                            items.Add(call);
                            break;
                        case "Part":
                            var part = new Part_T();
                            part.ReadXml(reader);
                            items.Add(part);
                            break;
                        case "Parts":
                            var parts = new Parts_T();
                            parts.ReadXml(reader);
                            items.Add(parts);
                            break;
                        case "Wires":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var wires = new List<Wire_T>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Wire":
                                            var wire = new Wire_T();
                                            wire.ReadXml(reader);
                                            wires.Add(wire);
                                            break;
                                    }
                                }
                                if (wires.Count > 0) items.AddRange(wires);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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
            if (Items is null) yield break;
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    internal class FlgNet_T_v2 : FlgNet_T, IFlgNet_T
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Labels":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();
                                
                                var labels = new List<CompileUnitCommon.LabelDeclaration_T_v2>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "LabelDeclaration":
                                            var label = new CompileUnitCommon.LabelDeclaration_T_v2();
                                            label.ReadXml(reader);
                                            labels.Add(label);
                                            break;
                                    }
                                }
                                if (labels.Count > 0) items.AddRange(labels);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Access":
                            var access = new Access.Access_T_v2();
                            access.ReadXml(reader);
                            items.Add(access);
                            break;
                        case "Call":
                            var call = new Call_T_v2();
                            call.ReadXml(reader);
                            items.Add(call);
                            break;
                        case "Part":
                            var part = new Part_T_v2();
                            part.ReadXml(reader);
                            items.Add(part);
                            break;
                        case "Parts":
                            var parts = new Parts_T_v2();
                            parts.ReadXml(reader);
                            items.Add(parts);
                            break;
                        case "Wires":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();
                                
                                var wires = new List<Wire_T>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Wire":
                                            var wire = new Wire_T();
                                            wire.ReadXml(reader);
                                            wires.Add(wire);
                                            break;
                                    }
                                }
                                if (wires.Count > 0) items.AddRange(wires);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    internal class FlgNet_T_v3 : FlgNet_T_v2, IFlgNet_T
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Labels":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var labels = new List<CompileUnitCommon.LabelDeclaration_T_v2>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "LabelDeclaration":
                                            var label = new CompileUnitCommon.LabelDeclaration_T_v2();
                                            label.ReadXml(reader);
                                            labels.Add(label);
                                            break;
                                    }
                                }
                                if (labels.Count > 0) items.AddRange(labels);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Access":
                            var access = new Access.Access_T_v3();
                            access.ReadXml(reader);
                            items.Add(access);
                            break;
                        case "Call":
                            var call = new Call_T_v3();
                            call.ReadXml(reader);
                            items.Add(call);
                            break;
                        case "Part":
                            var part = new Part_T_v3();
                            part.ReadXml(reader);
                            items.Add(part);
                            break;
                        case "Parts":
                            var parts = new Parts_T_v3();
                            parts.ReadXml(reader);
                            items.Add(parts);
                            break;
                        case "Wires":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();
                                
                                var wires = new List<Wire_T>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Wire":
                                            var wire = new Wire_T();
                                            wire.ReadXml(reader);
                                            wires.Add(wire);
                                            break;
                                    }
                                }
                                if (wires.Count > 0) items.AddRange(wires);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    internal class FlgNet_T_v4 : FlgNet_T_v3, IFlgNet_T
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Labels":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var labels = new List<Object_G>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "LabelDeclaration":
                                            var label = new CompileUnitCommon.LabelDeclaration_T_v4();
                                            label.ReadXml(reader);
                                            labels.Add(label);
                                            break;
                                    }
                                }
                                if (labels.Count > 0) items.AddRange(labels);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Access":
                            var access = new Access.Access_T_v4();
                            access.ReadXml(reader);
                            items.Add(access);
                            break;
                        case "Call":
                            var call = new Call_T_v4();
                            call.ReadXml(reader);
                            items.Add(call);
                            break;
                        case "Part":
                            var part = new Part_T_v4();
                            part.ReadXml(reader);
                            items.Add(part);
                            break;
                        case "Parts":
                            var parts = new Parts_T_v4();
                            parts.ReadXml(reader);
                            items.Add(parts);
                            break;
                        case "Wires":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            { 
                                reader.Read();

                                var wires = new List<Wire_T>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Wire":
                                            var wire = new Wire_T();
                                            wire.ReadXml(reader);
                                            wires.Add(wire);
                                            break;
                                    }
                                }
                                if (wires.Count > 0) items.AddRange(wires);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    internal class FlgNet_T_v5 : FlgNet_T_v4, IFlgNet_T
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Labels":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var labels = new List<CompileUnitCommon.LabelDeclaration_T_v4>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "LabelDeclaration":
                                            var label = new CompileUnitCommon.LabelDeclaration_T_v4();
                                            label.ReadXml(reader);
                                            labels.Add(label);
                                            break;
                                    }
                                }
                                if (labels.Count > 0) items.AddRange(labels);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "Access":
                            var access = new Access.Access_T_v5();
                            access.ReadXml(reader);
                            items.Add(access);
                            break;
                        case "Call":
                            var call = new Call_T_v5();
                            call.ReadXml(reader);
                            items.Add(call);
                            break;
                        case "Part":
                            var part = new Part_T_v5();
                            part.ReadXml(reader);
                            items.Add(part);
                            break;
                        case "Parts":
                            var parts = new Parts_T_v5();
                            parts.ReadXml(reader);
                            items.Add(parts);
                            break;
                        case "Wires":
                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var wires = new List<Wire_T>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Wire":
                                            var wire = new Wire_T();
                                            wire.ReadXml(reader);
                                            wires.Add(wire);
                                            break;
                                    }
                                }
                                if (wires.Count > 0) items.AddRange(wires);
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
