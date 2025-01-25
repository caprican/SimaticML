using System;
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
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T : Object_G
    {
        public Access.CallInfo_T CallInfo { get; set; }

        [XmlElement("TemplateValue")]
        public Access.TemplateValue_T[] TemplateValue { get; set; }

        [XmlElement("AutomaticTyped")]
        public AutomaticTyped_T[] AutomaticTyped { get; set; }

        [XmlElement("Invisible")]
        public Invisible_T[] Invisible { get; set; }

        [XmlElement("Negated")]
        public Neg_T[] Negated { get; set; }

        public Common.Comment_T Comment { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T>();
                var automticTypdes = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            CallInfo = new Access.CallInfo_T();
                            CallInfo.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var typed = new AutomaticTyped_T();
                            typed.ReadXml(reader);
                            automticTypdes.Add(typed);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T();
                            Comment.ReadXml(reader);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            invisibles.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            negateds.Add(neg);
                            break;
                    }
                }
                if (templates.Count > 0) TemplateValue = templates.ToArray();
                if (automticTypdes.Count > 0) AutomaticTyped = automticTypdes.ToArray();
                if (invisibles.Count > 0) Invisible = invisibles.ToArray();
                if (negateds.Count > 0) Negated = negateds.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v2 : Call_T
    {
        public new Access.CallInfo_T_v2 CallInfo { get; set; }

        [XmlElement("TemplateValue")]
        public new Access.TemplateValue_T_v2[] TemplateValue { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var automticTypdes = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            CallInfo = new Access.CallInfo_T_v2();
                            CallInfo.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var typed = new AutomaticTyped_T();
                            typed.ReadXml(reader);
                            automticTypdes.Add(typed);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            invisibles.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            negateds.Add(neg);
                            break;
                    }
                }
                if (templates.Count > 0) TemplateValue = templates.ToArray();
                if (automticTypdes.Count > 0) AutomaticTyped = automticTypdes.ToArray();
                if (invisibles.Count > 0) Invisible = invisibles.ToArray();
                if (negateds.Count > 0) Negated = negateds.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v3 : Call_T_v2
    {
        public new Access.CallInfo_T_v3 CallInfo { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var automticTypdes = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            CallInfo = new Access.CallInfo_T_v3();
                            CallInfo.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var typed = new AutomaticTyped_T();
                            typed.ReadXml(reader);
                            automticTypdes.Add(typed);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            invisibles.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            negateds.Add(neg);
                            break;
                    }
                }
                if (templates.Count > 0) TemplateValue = templates.ToArray();
                if (automticTypdes.Count > 0) AutomaticTyped = automticTypdes.ToArray();
                if (invisibles.Count > 0) Invisible = invisibles.ToArray();
                if (negateds.Count > 0) Negated = negateds.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v4 : Call_T_v3
    {
        public new Access.CallInfo_T_v4 CallInfo { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var automticTypdes = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            CallInfo = new Access.CallInfo_T_v4();
                            CallInfo.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var typed = new AutomaticTyped_T();
                            typed.ReadXml(reader);
                            automticTypdes.Add(typed);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            invisibles.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            negateds.Add(neg);
                            break;
                    }
                }
                if (templates.Count > 0) TemplateValue = templates.ToArray();
                if (automticTypdes.Count > 0) AutomaticTyped = automticTypdes.ToArray();
                if (invisibles.Count > 0) Invisible = invisibles.ToArray();
                if (negateds.Count > 0) Negated = negateds.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v5 : Call_T_v4
    {
        public new Access.CallInfo_T_v5 CallInfo { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var automticTypdes = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            CallInfo = new Access.CallInfo_T_v5();
                            CallInfo.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var typed = new AutomaticTyped_T();
                            typed.ReadXml(reader);
                            automticTypdes.Add(typed);
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            invisibles.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            negateds.Add(neg);
                            break;
                    }
                }
                if (templates.Count > 0) TemplateValue = templates.ToArray();
                if (automticTypdes.Count > 0) AutomaticTyped = automticTypdes.ToArray();
                if (invisibles.Count > 0) Invisible = invisibles.ToArray();
                if (negateds.Count > 0) Negated = negateds.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
