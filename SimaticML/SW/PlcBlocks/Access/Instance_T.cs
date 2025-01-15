using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instance", Namespace="", IsNullable=false)]
    public class Instance_T
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Component", typeof(Component_T))]
        [XmlElement("Token", typeof(Common.Token_T))]                           // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        [XmlElement("Address", typeof(Address_T))]                              // additional address for a symbol. it is informative
        public object[] Items { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public Scope_TE Scope { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instance", Namespace = "", IsNullable = false)]
    public class Instance_T_v2 : Instance_T
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        [XmlElement("Component", typeof(Component_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }

        [XmlAttribute]
        public new Scope_TE_v2 Scope { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instance", Namespace = "", IsNullable = false)]
    public class Instance_T_v3 : Instance_T_v2
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        [XmlElement("Component", typeof(Component_T_v3))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }

        [XmlAttribute]
        public new Scope_TE_v2 Scope { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instance", Namespace = "", IsNullable = false)]
    public class Instance_T_v4 : Instance_T_v3
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        [XmlElement("Component", typeof(Component_T_v4))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instance", Namespace = "", IsNullable = false)]
    public class Instance_T_v5 : Instance_T_v4
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        [XmlElement("Component", typeof(Component_T_v5))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }

        [XmlAttribute]
        public new Scope_TE_v5 Scope { get; set; }
    }
}
