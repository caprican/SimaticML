﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", IsNullable = false)]
    public class Parts_T : Object_G
    {
        [XmlElement("Access", typeof(Access.Access_T))]
        [XmlElement("Call", typeof(Call_T))]
        [XmlElement("Part", typeof(Part_T))]
        public Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", IsNullable = false)]
    public class Parts_T_v2 : Parts_T
    {
        [XmlElement("Access", typeof(Access.Access_T_v2))]
        [XmlElement("Call", typeof(Call_T_v2))]
        [XmlElement("Part", typeof(Part_T_v2))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", IsNullable = false)]
    public class Parts_T_v3 : Parts_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T_v3))]
        [XmlElement("Call", typeof(Call_T_v3))]
        [XmlElement("Part", typeof(Part_T_v3))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", IsNullable = false)]
    public class Parts_T_v4 : Parts_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T_v4))]
        [XmlElement("Call", typeof(Call_T_v4))]
        [XmlElement("Part", typeof(Part_T_v4))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parts", IsNullable = false)]
    public class Parts_T_v5 : Parts_T_v4
    {
        [XmlElement("Access", typeof(Access.Access_T_v5))]
        [XmlElement("Call", typeof(Call_T_v5))]
        [XmlElement("Part", typeof(Part_T_v5))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
