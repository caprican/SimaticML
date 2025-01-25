using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

using SimaticML.SW.PlcBlocks.Graph;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T : Object_G
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T))]
        public Object_G Item { get; set; }

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

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool DisabledENO { get; set; } = false;

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("DisabledENO"), out var disable);
            DisabledENO = disable;

            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            Name = reader.GetAttribute("Name");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T>();
                var typeds = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            Item = equation;
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T();
                            instance.ReadXml(reader);
                            Item = instance;
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T();
                            Comment.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            typeds.Add(type);
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
                if (typeds.Count > 0) AutomaticTyped = typeds.ToArray();
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
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v2 : Part_T
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v2))]
        public new Object_G Item { get; set; }

        [XmlElement("TemplateValue")]
        public new Access.TemplateValue_T_v2[] TemplateValue { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("DisabledENO"), out var disable);
            DisabledENO = disable;

            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            Name = reader.GetAttribute("Name");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var typeds = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            Item = equation;
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v2();
                            instance.ReadXml(reader);
                            Item = instance;
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            typeds.Add(type);
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
                if (typeds.Count > 0) AutomaticTyped = typeds.ToArray();
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
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v3 : Part_T_v2
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v3))]
        public new Object_G Item { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("DisabledENO"), out var disable);
            DisabledENO = disable;

            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            Name = reader.GetAttribute("Name");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var typeds = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            Item = equation;
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v3();
                            instance.ReadXml(reader);
                            Item = instance;
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            typeds.Add(type);
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
                if (typeds.Count > 0) AutomaticTyped = typeds.ToArray();
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
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v4 : Part_T_v3
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v4))]
        public new Object_G Item { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("DisabledENO"), out var disable);
            DisabledENO = disable;

            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            Name = reader.GetAttribute("Name");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var typeds = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            Item = equation;
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v4();
                            instance.ReadXml(reader);
                            Item = instance;
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            typeds.Add(type);
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
                if (typeds.Count > 0) AutomaticTyped = typeds.ToArray();
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
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v5 : Part_T_v4
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v5))]
        public new Object_G Item { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("DisabledENO"), out var disable);
            DisabledENO = disable;

            _ = int.TryParse(reader.GetAttribute("UId"), out var uId);
            UId = uId;

            Name = reader.GetAttribute("Name");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var templates = new List<Access.TemplateValue_T_v2>();
                var typeds = new List<AutomaticTyped_T>();
                var invisibles = new List<Invisible_T>();
                var negateds = new List<Neg_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            Item = equation;
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v5();
                            instance.ReadXml(reader);
                            Item = instance;
                            break;
                        case "Comment":
                            Comment = new Common.Comment_T_v2();
                            Comment.ReadXml(reader);
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            templates.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            typeds.Add(type);
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
                if (typeds.Count > 0) AutomaticTyped = typeds.ToArray();
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
