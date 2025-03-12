using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    public interface IFlgNet_T
    {
        CompileUnitCommon.ILabelDeclaration_T[] Labels { get; set; }
        Object_G[] Parts { get; set; }
        IWire_T[] Wires { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    public class FlgNet_T : Object_G, IFlgNet_T
    {
        //[XmlArray("Labels")]
        //[XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T))]
        public CompileUnitCommon.ILabelDeclaration_T[] Labels { get; set; }

        //[XmlArrayItem("Access", typeof(Access.Access_T), IsNullable = false)]
        //[XmlArrayItem("Call", typeof(Call_T), IsNullable = false)]
        //[XmlArrayItem("Part", typeof(Part_T), IsNullable = false)]
        public Object_G[] Parts { get; set; }

        [XmlArray("Wires")]
        //[XmlArrayItem("Wire", typeof(Wire_T))]
        public IWire_T[] Wires { get; set; }

        public override void ReadXml(XmlReader reader)
        {
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
                            if (labels.Count > 0) Labels = labels.ToArray();
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
                        case "Wires":
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
                            if (wires.Count > 0) Wires = wires.ToArray();
                            break;
                    }
                }
                if (items.Count > 0) Parts = items.ToArray();
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
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    public class FlgNet_T_v2 : FlgNet_T, IFlgNet_T
    {
        //[XmlArray("Labels")]
        //[XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v2))]
        //public new CompileUnitCommon.ILabelDeclaration_T[] Labels { get; set; }

        //[XmlArrayItem("Access", typeof(Access.Access_T_v2), IsNullable = false)]
        //[XmlArrayItem("Call", typeof(Call_T_v2), IsNullable = false)]
        //[XmlArrayItem("Part", typeof(Part_T_v2), IsNullable = false)]
        public new Object_G[] Parts { get; set; }

        public override void ReadXml(XmlReader reader)
        {
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
                            if (labels.Count > 0) Labels = labels.ToArray();
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
                        case "Wires":
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
                            if (wires.Count > 0) Wires = wires.ToArray();
                            break;
                    }
                }
                if (items.Count > 0) Parts = items.ToArray();
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
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    public class FlgNet_T_v3 : FlgNet_T_v2, IFlgNet_T
    {
        //[XmlArrayItem("Access", typeof(Access.Access_T_v3), IsNullable = false)]
        //[XmlArrayItem("Call", typeof(Call_T_v3), IsNullable = false)]
        //[XmlArrayItem("Part", typeof(Part_T_v3), IsNullable = false)]
        public new Object_G[] Parts { get; set; }

        public override void ReadXml(XmlReader reader)
        {
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
                            if (labels.Count > 0) Labels = labels.ToArray();
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
                        case "Wires":
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
                            if (wires.Count > 0) Wires = wires.ToArray();
                            break;
                    }
                }
                if (items.Count > 0) Parts = items.ToArray();
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
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    public class FlgNet_T_v4 : FlgNet_T_v3, IFlgNet_T
    {
        //[XmlArray("Labels")]
        //[XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v4))]
        //public new CompileUnitCommon.LabelDeclaration_T_v4[] Labels { get; set; }

        //[XmlArrayItem("Access", typeof(Access.Access_T_v4), IsNullable = false)]
        //[XmlArrayItem("Call", typeof(Call_T_v4), IsNullable = false)]
        //[XmlArrayItem("Part", typeof(Part_T_v4), IsNullable = false)]
        //public new Object_G[] Parts { get; set; }

        public override void ReadXml(XmlReader reader)
        {
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
                            if (labels.Count > 0) Labels = labels.ToArray();
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
                        case "Wires":
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
                            if (wires.Count > 0) Wires = wires.ToArray();
                            break;
                    }
                }
                if (items.Count > 0) Parts = items.ToArray();
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
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("FlgNet", IsNullable = false)]
    public class FlgNet_T_v5 : FlgNet_T_v4, IFlgNet_T
    {
        //[XmlArrayItem("Access", typeof(Access.Access_T_v5), IsNullable = false)]
        //[XmlArrayItem("Call", typeof(Call_T_v5), IsNullable = false)]
        //[XmlArrayItem("Part", typeof(Part_T_v5), IsNullable = false)]
        //public new Object_G[] Parts { get; set; }

        public override void ReadXml(XmlReader reader)
        {
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
                            if (labels.Count > 0) Labels = labels.ToArray();
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
                        case "Wires":
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
                            if (wires.Count > 0) Wires = wires.ToArray();
                            break;
                    }
                }
                if (items.Count > 0) Parts = items.ToArray();
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
