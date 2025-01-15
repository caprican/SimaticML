using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    public class CallInfo_T
    {
        //[XmlElement(Order = 0)]
        //public IntegerAttribute_T IntegerAttribute { get; set; }

        //[XmlElement(Order = 1)]
        //public DateAttribute_T DateAttribute { get; set; }

        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T), Order = 0)]
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        [XmlElement("DateAttribute", typeof(Common.DateAttribute_T), Order = 1)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 3)]
        [XmlElement("Instance", typeof(Instance_T), Order = 5)]
        [XmlElement("Parameter", typeof(Parameter_T), Order = 6)]
        public object[] Items { get; set; }

        //[XmlElement(Order = 3)]
        //public Token_T Token { get; set; }

        //[XmlElement("Comment", typeof(Comment), Order = 4)]
        //[XmlElement("LineComment", typeof(LineComment_T), Order = 4)]
        //public object[] Items1 { get; set; }

        //[XmlElement(Order = 5)]
        //public Instance_T Instance { get; set; }

        //[XmlElement("Parameter", Order = 6)]
        //public Parameter_T[] Parameter { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public BlockType_TE BlockType { get; set; }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", Namespace = "", IsNullable = false)]
    public class CallInfo_T_v2 : CallInfo_T
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3 | 6 | 9)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3 | 6 | 9)]
        [XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2), Order = 0)]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), Order = 0)]          // for BlockNumber. BlockNumber is informative.
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3 | 6 | 9)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3 | 6 | 9)]
        [XmlElement("Token", typeof(Common.Token_T_v2), Order = 0 | 2)]
        [XmlElement("Instance", typeof(Instance_T_v2), Order = 1)]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T), Order = 4)]
        [XmlElement("Token", typeof(Common.Token_T_v2), Order = 5 | 8)]
        [XmlElement("Parameter", typeof(Parameter_T_v2), Order = 7)]
        public new object[] Items { get; set; }

        //[XmlElement(Order = 1)]
        //public Instance_T Instance { get; set; }

        //[XmlElement("Token", Order = 2)]
        //public Token_T[] Token { get; set; }

        //[XmlElement("Blank", typeof(Common.Blank_T), Order = 3)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 3)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 3)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 3)]
        //public object[] Items1 { get; set; }

        //[XmlElement("NamelessParameter", Order = 4)]
        //public NamelessParameter_T[] NamelessParameter {  get; set; }

        //[XmlElement("Token", Order = 5)]
        //public Token_T[] Token1 { get; set; }

        //[XmlElement("Blank", typeof(Blank_T), Order = 6)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 6)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 6)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 6)]
        //public object[] Items2 { get; set; }

        //[XmlElement("Parameter", Order = 7)]
        //public Parameter_T[] Parameter { get; set; }

        //[XmlElement("Token", Order = 8)]
        //public Token_T[] Token2 { get; set; }

        //[XmlElement("Blank", typeof(Blank_T), Order = 9)]
        //[XmlElement("Comment", typeof(Comment_T), Order = 9)]
        //[XmlElement("LineComment", typeof(LineComment_T), Order = 9)]
        //[XmlElement("NewLine", typeof(NewLine_T), Order = 9)]
        //public object[] Items3 { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", Namespace = "", IsNullable = false)]
    public class CallInfo_T_v3 : CallInfo_T_v2
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        [XmlElement("Instance", typeof(Instance_T_v3))]
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2))]          // for BlockNumber. BlockNumber is informative.
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T_v3))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", Namespace = "", IsNullable = false)]
    public class CallInfo_T_v4 : CallInfo_T_v3
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        [XmlElement("Instance", typeof(Instance_T_v4))]
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2))]          // for BlockNumber. BlockNumber is informative.
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T_v4))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T_v4))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", Namespace = "", IsNullable = false)]
    public class CallInfo_T_v5 : CallInfo_T_v4
    {
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        [XmlElement("Instance", typeof(Instance_T_v5))]
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2))]          // for BlockNumber. BlockNumber is informative.
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NamelessParameter", typeof(NamelessParameter_T_v5))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T_v5))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new object[] Items { get; set; }
    }
}
