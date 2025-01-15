namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    ///          SW_InterfaceSections_v3 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    ///          SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    public enum MemberAttributes_TE
    {
        /// <summary>
        /// Write acces only inside function
        /// </summary>
        CodeReadOnly,

        /// <summary>
        /// string: Member shares offset with another member in this structure
        /// </summary>
        At,

        /// <summary>
        /// boolean: Member can be synchronized with work memory
        /// </summary>
        SetPoint,

        /// <summary>
        /// boolean: Editor does not show the member
        /// </summary>
        UserVisible,

        /// <summary>
        /// boolean: User cannot change member name
        /// </summary>
        UserReadOnly,

        /// <summary>
        /// boolean: Editor does not allow to delete the member
        /// </summary>
        UserDeletable,

        /// <summary>
        /// boolean: No HMI access, no structure item
        /// </summary>
        HmiAccessible,

        /// <summary>
        /// boolean: Filter to reduce the number of members shown in the first place
        /// </summary>
        HmiVisible,

        /// <summary>
        /// integer: 
        /// </summary>
        Offset,

        /// <summary>
        /// integer: 
        /// </summary>
        PaddedSize,

        /// <summary>
        /// boolean: Hide assignement at call if matches with PredefinedAssignment
        /// </summary>
        HiddenAssignment,

        /// <summary>
        /// string: Input for the paramter used when call is placed
        /// </summary>
        PredefinedAssignment,

        /// <summary>
        /// boolean: The user cannot change the predefined assignement at the call
        /// </summary>
        ReadOnlyAssignment
    }
}
