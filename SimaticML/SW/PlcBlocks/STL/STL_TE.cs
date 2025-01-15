using System;

namespace SimaticML.SW.PlcBlocks.STL
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    ///          SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    ///          SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    public enum STL_TE
    {
        A,
        AN,
        O,
        ON,
        X,
        XN,
        S,
        R,
        Assign,
        Rise,
        Fall,
        L,
        T,
        LAR1,
        LAR2,
        TAR1,
        TAR2,

        /// <summary>
        /// SE, SV
        /// </summary>
        Extend,
        Free,
        LC,

        /// <summary>
        /// SF, SA
        /// </summary>
        OffDelay,

        /// <summary>
        /// SS
        /// </summary>
        Retentive,

        /// <summary>
        /// SD, SE
        /// </summary>
        OnDelay,

        /// <summary>
        /// SP, SI
        /// </summary>
        Pulse,

        CD,
        CU,
        CALL,
        CC,
        UC,

        /// <summary>
        /// AUF
        /// </summary>
        OPEN_DB,

        /// <summary>
        /// AUF DI
        /// </summary>
        OPEN_DI,

        LT_I,
        LT_R,
        LT_D,
        LE_I,
        LE_R,
        LE_D,
        EQ_I,
        EQ_R,
        EQ_D,
        GE_I,
        GE_R,
        GE_D,
        GT_I,
        GT_R,
        GT_D,
        NE_I,
        NE_R,
        NE_D,

        /// <summary>
        /// SPA
        /// </summary>
        JU,

        /// <summary>
        /// SPB
        /// </summary>
        JC,

        /// <summary>
        /// SPO
        /// </summary>
        JO,

        /// <summary>
        /// SPZ
        /// </summary>
        JZ,

        /// <summary>
        /// SPP
        /// </summary>
        JP,

        /// <summary>
        /// SPM
        /// </summary>
        JM,

        /// <summary>
        /// SPN
        /// </summary>
        JN,

        /// <summary>
        /// SPBN
        /// </summary>
        JCN,

        /// <summary>
        /// SPBB
        /// </summary>
        JCB,

        /// <summary>
        /// SPBNB
        /// </summary>
        JNB,

        /// <summary>
        /// SPBI
        /// </summary>
        JBI,

        /// <summary>
        /// SPBNI
        /// </summary>
        JNBI,

        /// <summary>
        /// SPS
        /// </summary>
        JOS,

        /// <summary>
        /// SPU
        /// </summary>
        JUN,

        /// <summary>
        /// SPMZ
        /// </summary>
        JMZ,

        /// <summary>
        /// SPZ
        /// </summary>
        JPZ,

        LOOP,
        JL,
        ADD,
        SLD,
        SLW,
        SRD,
        SRW,

        /// <summary>
        /// SSD, SVD
        /// </summary>
        SRSD,

        /// <summary>
        /// SSW, SVW
        /// </summary>
        SRSW,

        RLD,
        RRD,
        BLD,
        ADDAR1,
        ADDAR2,
        INC,
        DEC,
        AW,
        OW,
        XW,
        AD,
        OD,
        XD,
        A_BRACK,
        AN_BRACK,
        O_BRACK,
        ON_BRACK,
        X_BRACK,
        XN_BRACK,

        /// <summary>
        /// KEW, INV_F
        /// </summary>
        INV_I,

        /// <summary>
        /// KZW, NEG_F
        /// </summary>
        NEG_I,

        /// <summary>
        /// KED
        /// </summary>
        INV_D,

        /// <summary>
        /// KZD
        /// </summary>
        NEG_D,

        /// <summary>
        /// NEG_G, ND
        /// </summary>
        NEG_R,

        /// <summary>
        /// ABS_G
        /// </summary>
        ABS_R,

        SQRT,
        SQR,
        LN,
        EXP,
        SIN,
        ASIN,
        COS,
        ACOS,
        TAN,
        ATAN,
        RLDA,
        RRDA,

        /// <summary>
        /// DEF
        /// </summary>
        BTI,

        /// <summary>
        /// DUF
        /// </summary>
        ITB,

        /// <summary>
        /// DED
        /// </summary>
        BTD,

        /// <summary>
        /// DUD
        /// </summary>
        DTB,

        /// <summary>
        /// FDG
        /// </summary>
        DTR,

        /// <summary>
        /// GFDN
        /// </summary>
        RND,

        /// <summary>
        /// GFDM
        /// </summary>
        RND_M,

        /// <summary>
        /// GFDP
        /// </summary>
        RND_P,

        TRUNC,

        /// <summary>
        /// FD
        /// </summary>
        ITD,

        /// <summary>
        /// TAW
        /// </summary>
        CAW,

        /// <summary>
        /// TAD
        /// </summary>
        CAD,

        TAR1_ACCU1,
        TAR2_ACCU1,

        /// <summary>
        /// +F
        /// </summary>
        ADD_I,

        /// <summary>
        /// -F
        /// </summary>
        SUB_I,

        /// <summary>
        /// xF
        /// </summary>
        MUL_I,

        /// <summary>
        /// :F
        /// </summary>
        DIV_I,

        /// <summary>
        /// +D
        /// </summary>
        ADD_D,

        /// <summary>
        /// -D
        /// </summary>
        SUB_D,

        /// <summary>
        /// xD
        /// </summary>
        MUL_D,

        /// <summary>
        /// :D
        /// </summary>
        DIV_D,

        MOD_D,
        L_DBLG,
        L_DILG,
        L_DBNO,
        L_DINO,

        /// <summary>
        /// +G
        /// </summary>
        ADD_R,

        /// <summary>
        /// -G
        /// </summary>
        SUB_R,

        /// <summary>
        /// xG
        /// </summary>
        MUL_R,

        /// <summary>
        /// :G
        /// </summary>
        DIV_R,

        /// <summary>
        /// TAK
        /// </summary>
        CAC,
        LEAVE,
        PUSH,
        POP,
        SET,
        NEG,
        CLR,

        /// <summary>
        /// BEB
        /// </summary>
        BEC,

        /// <summary>
        /// )
        /// </summary>
        BRACKET,
        SAVE,
        NOP_0,
        NOP_1,

        /// <summary>
        /// MCR(
        /// </summary>
        MCR_BRACK,

        /// <summary>
        /// MCR)
        /// </summary>
        BRACK_MCR,

        MCRA,
        MCRD,
        ENT,
        LAR1_ACCU1,
        LAR1_AR2,
        LAR2_ACCU1,
        TAR1_AR2,

        /// <summary>
        /// TAR
        /// </summary>
        CAR,

        /// <summary>
        /// TDB
        /// </summary>
        CDB,
        COMMENT,
        EMPTY_LINE,
        PSEUDO,
        MOVE,
        MOVE_BLOCK,

        /// <summary>
        /// BEA
        /// </summary>
        BE,
        BEU,
    }
}
