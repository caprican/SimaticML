using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataAxis
{
    /// <summary>
    /// Contains a list of master values for TO_SynchronousAxis.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Axis/v1")]
    public class SynchronousAxisMasterValues_T
    {
        /// <summary>
        /// Describes a reference to a master value TO that is coupled via set points.
        /// </summary>
        [XmlElement("SetPointCoupling")]
        public TechnologicalObjectReference_T[] SetPointCoupling { get; set; }

        /// <summary>
        /// Describes a reference to a master value TO that is coupled via actual values.
        /// </summary>
        [XmlElement("ActualValueCoupling")]
        public TechnologicalObjectReference_T[] ActualValueCoupling { get; set; }

        /// <summary>
        /// Describes a reference to a master value TO that is coupled via delayed values.
        /// </summary>
        [XmlElement("DelayedCoupling")]
        public TechnologicalObjectReference_T[] DelayedCoupling { get; set; }

        /// <summary>
        /// Describes a reference to a master value TO of type LeadingAxisProxy.
        /// </summary>
        [XmlElement("LeadingAxisProxy")]
        public TechnologicalObjectReference_T[] LeadingAxisProxy { get; set; }
    }
}
