using System;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    ///          SW_InterfaceSections_v3 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    ///          SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    public enum Remanence_TE
    {
        SetInIDB,
        NonRetain,
        Retain
    }
}
