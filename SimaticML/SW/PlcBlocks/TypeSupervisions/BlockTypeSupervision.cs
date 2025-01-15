using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BlockTypeSupervision
    {
        public SupervisedOperand SupervisedOperand { get; set; }

        public bool SupervisedStatus { get; set; }

        public DelayOperand DelayOperand { get; set; }

        [XmlArrayItem("Condition", IsNullable = false)]
        public Condition[] Conditions { get; set; }

        public int CategoryNumber { get; set; }

        public long SubCategory1Number { get; set; }
        [XmlIgnore]
        public bool SubCategory1NumberSpecified { get; set; }

        public long SubCategory2Number { get; set; }
        [XmlIgnore]
        public bool SubCategory2NumberSpecified { get; set; }

        public SpecificField SpecificField { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public Type Type { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BlockTypeSupervision_v2 : BlockTypeSupervision
    {
        public new SpecificField_v2 SpecificField { get; set; }
    }
}
