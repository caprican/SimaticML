using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// For the indices of an array
    /// </summary>

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", Namespace = "", IsNullable = false)]
    public class Component_T
    {
        public Component_T()
        {
            SliceAccessModifier = "undef";
            SimpleAccessModifier = "None";
        }

        [XmlElement("Access", typeof(Access_T))]                                 // For the indices of an array
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        [DefaultValue("undef")]
        public string SliceAccessModifier { get; set; }

        [XmlAttribute]
        [DefaultValue("None")]
        public string SimpleAccessModifier { get; set; }
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", Namespace = "", IsNullable = false)]
    public class Component_T_v2 : Component_T
    {
        public Component_T_v2()
        {
            SliceAccessModifier = "undef";
            SimpleAccessModifier = "None";

            AccessModifier = AccessModifier_TE.None;
        }

        [XmlElement("Access", typeof(Access_T_v2))]                                 // For the indices of an array
        [XmlElement("Blank", typeof(Common.Blank_T))]                            // SCL
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]                // SCL
        [XmlElement("NewLine", typeof(Common.NewLine_T))]                        // SCL
        [XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL
        public new object[] Items { get; set; }

        /// <summary>
        /// If component has child AccessModifier is Array else AccessModifier is None
        /// </summary>
        [XmlAttribute]
        [DefaultValue(AccessModifier_TE.None)]
        public AccessModifier_TE AccessModifier { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", Namespace = "", IsNullable = false)]
    public class Component_T_v3 : Component_T_v2
    {
        [XmlElement("Access", typeof(Access_T_v3))]                                 // For the indices of an array
        [XmlElement("Blank", typeof(Common.Blank_T))]                            // SCL
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]                // SCL
        [XmlElement("NewLine", typeof(Common.NewLine_T))]                        // SCL
        [XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL
        public new object[] Items { get; set; }
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", Namespace = "", IsNullable = false)]
    public class Component_T_v4 : Component_T_v3
    {
        [XmlElement("Access", typeof(Access_T_v4))]                                 // For the indices of an array
        [XmlElement("Blank", typeof(Common.Blank_T))]                            // SCL
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]                // SCL
        [XmlElement("NewLine", typeof(Common.NewLine_T))]                        // SCL
        [XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL
        public new object[] Items { get; set; }
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", Namespace = "", IsNullable = false)]
    public class Component_T_v5 : Component_T_v4
    {
        [XmlElement("Access", typeof(Access_T_v5))]                                 // For the indices of an array
        [XmlElement("Blank", typeof(Common.Blank_T))]                            // SCL
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]                // SCL
        [XmlElement("NewLine", typeof(Common.NewLine_T))]                        // SCL
        [XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL
        public new object[] Items { get; set; }
    }
}
