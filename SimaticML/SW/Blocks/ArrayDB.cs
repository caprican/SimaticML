using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class ArrayDB : Object_T
    {
        public AttributeArrayDB AttributeList { get; set; }

        public class AttributeArrayDB : AttributeList_G
        {
            public string ArrayDataType { get; set; }
            [XmlIgnore]
            public bool ArrayDataTypeSpecified { get; set; }

            public int ArrayLimitUpperBound { get; set; }
            [XmlIgnore]
            public bool ArrayLimitUpperBoundSpecified { get; set; }
        }
    }
}
