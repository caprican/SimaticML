using System;
using System.ComponentModel;
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
    [XmlRoot("Part", Namespace = "", IsNullable = false)]
    public class Part_T
    {
        public Part_T()
        {
            DisabledENO = false;
        }

        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T))]
        public object Item { get; set; }

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
        public bool DisabledENO { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", Namespace = "", IsNullable = false)]
    public class Part_T_v2 : Part_T
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v2))]
        public new object Item { get; set; }

        [XmlElement("TemplateValue")]
        public new Access.TemplateValue_T_v2[] TemplateValue { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", Namespace = "", IsNullable = false)]
    public class Part_T_v3 : Part_T_v2
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v3))]
        public new object Item { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", Namespace = "", IsNullable = false)]
    public class Part_T_v4 : Part_T_v3
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v4))]
        public new object Item { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", Namespace = "", IsNullable = false)]
    public class Part_T_v5 : Part_T_v4
    {
        [XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        [XmlElement("Instance", typeof(Access.Instance_T_v5))]
        public new object Item { get; set; }
    }
}
