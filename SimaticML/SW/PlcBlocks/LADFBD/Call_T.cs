using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    public interface ICall_T
    {
        Access.ICallInfo CallInfo { get; set; }
        Access.ITemplateValue[] TemplateValue { get; set; }
        IAutomaticTyped[] AutomaticTyped { get; set; }
        IInvisible[] Invisible { get; set; }
        INeg[] Negated { get; set; }
        Common.IComment Comment { get; set; }
        int UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T : Object_G, ICall_T
    {
        public Access.ICallInfo CallInfo { get; set; }

        [XmlElement("TemplateValue")]
        public Access.ITemplateValue[] TemplateValue { get; set; }

        [XmlElement("AutomaticTyped")]
        public IAutomaticTyped[] AutomaticTyped { get; set; }

        [XmlElement("Invisible")]
        public IInvisible[] Invisible { get; set; }

        [XmlElement("Negated")]
        public INeg[] Negated { get; set; }

        public Common.IComment Comment { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.ITemplateValue>();
                var automticTypdes = new List<IAutomaticTyped>();
                var invisibles = new List<IInvisible>();
                var negateds = new List<INeg>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            var callInfo = new Access.CallInfo_T();
                            callInfo.ReadXml(reader);
                            CallInfo = callInfo;
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
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            Comment = comment;
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
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v2 : Call_T, ICall_T
    {
        //public new Access.CallInfo_T_v2 CallInfo { get; set; }

        //[XmlElement("TemplateValue")]
        //public new Access.TemplateValue_T_v2[] TemplateValue { get; set; }

        //public new Common.Comment_T_v2 Comment { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.ITemplateValue_v2>();
                var automticTypdes = new List<IAutomaticTyped>();
                var invisibles = new List<IInvisible>();
                var negateds = new List<INeg>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            var callInfo = new Access.CallInfo_T_v2();
                            callInfo.ReadXml(reader);
                            CallInfo = callInfo;
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
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
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
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v3 : Call_T_v2, ICall_T
    {
        //public new Access.CallInfo_T_v3 CallInfo { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.ITemplateValue_v2>();
                var automticTypdes = new List<IAutomaticTyped>();
                var invisibles = new List<IInvisible>();
                var negateds = new List<INeg>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            var callInfo = new Access.CallInfo_T_v3();
                            callInfo.ReadXml(reader);
                            CallInfo = callInfo;
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
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
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
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v4 : Call_T_v3, ICall_T
    {
        //public new Access.CallInfo_T_v4 CallInfo { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.ITemplateValue_v2>();
                var automticTypdes = new List<IAutomaticTyped>();
                var invisibles = new List<IInvisible>();
                var negateds = new List<INeg>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            var callInfo = new Access.CallInfo_T_v4();
                            callInfo.ReadXml(reader);
                            CallInfo = callInfo;
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
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
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
    [XmlRoot("Call", IsNullable = false)]
    public class Call_T_v5 : Call_T_v4, ICall_T
    {
        //public new Access.CallInfo_T_v5 CallInfo { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.ITemplateValue_v2>();
                var automticTypdes = new List<IAutomaticTyped>();
                var invisibles = new List<IInvisible>();
                var negateds = new List<INeg>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "CallInfo":
                            var callInfo = new Access.CallInfo_T_v5();
                            callInfo.ReadXml(reader);
                            CallInfo = callInfo;
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
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
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
