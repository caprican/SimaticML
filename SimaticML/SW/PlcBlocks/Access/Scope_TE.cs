using System;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    public enum Scope_TE
    {
        /// <summary>
        /// Symbols we do not know what they are
        /// </summary>
        Undef,
        GlobalConstant,
        LocalConstant,
        GlobalVariable,
        LocalVariable,
        Instruction,
        Label,
        TypedConstant,
        AddressConstant,
        LiteralConstant,
        AlarmConstant,
        Address,
        Statusword,
        Expression,
        Unnamed,
        Call,
        CallWithType,
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    public enum Scope_TE_v2
    {
        /// <summary>
        /// Symbols we do not know what they are
        /// </summary>
        Undef,
        GlobalConstant,
        LocalConstant,
        GlobalVariable,
        LocalVariable,
        Instruction,
        Label,
        TypedConstant,
        AddressConstant,
        LiteralConstant,
        AlarmConstant,
        Address,
        Statusword,
        Expression,
        Unnamed,
        Call,
        CallWithType,
        UserType,
        SystemType,
        Reference,
        PredefinedVariable
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    public enum Scope_TE_v5
    {
        /// <summary>
        /// Symbols we do not know what they are
        /// </summary>
        Undef,
        GlobalConstant,
        LocalConstant,
        GlobalVariable,
        LocalVariable,
        Instruction,
        Label,
        TypedConstant,
        AddressConstant,
        LiteralConstant,
        AlarmConstant,
        Address,
        Statusword,
        Expression,
        Unnamed,
        Call,
        CallWithType,
        UserType,
        SystemType,
        Reference,
        PredefinedVariable,
        NamedValueConstant
    }
}
