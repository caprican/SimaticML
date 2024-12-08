using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataKinematics
{
    /// <summary>
    /// Contains a list of leading values for conveyor tracking.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Kinematics/v1")]
    public class ConveyorTrackingLeadingValues_T
    {
        /// <summary>
        /// Describes a reference to a leading value TO that is coupled via set points.
        /// </summary>
        [XmlElement("SetPointCoupling")]
        public TechnologicalObjectReference_T[] SetPointCoupling { get; set; }

        /// <summary>
        /// Describes a reference to a leading value TO that is coupled via actual values.
        /// </summary>
        [XmlElement("ActualValueCoupling")]
        public TechnologicalObjectReference_T[] ActualValueCoupling { get; set; }

        /// <summary>
        /// Describes a reference to a leading value TO that is coupled via delayed values.
        /// </summary>
        [XmlElement("DelayedCoupling")]
        public TechnologicalObjectReference_T[] DelayedCoupling { get; set; }

        /// <summary>
        /// Describes a reference to a leading value TO of type LeadingAxisProxy.
        /// </summary>
        [XmlElement("LeadingAxisProxy")]
        public TechnologicalObjectReference_T[] LeadingAxisProxy { get; set; }
    }
}
