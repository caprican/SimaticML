using System;

namespace SimaticML.SW.PlcBlocks.Access
{
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
        UserType,
        SystemType,
        Reference,
        PredefinedVariable,
        NamedValueConstant
    }
}
