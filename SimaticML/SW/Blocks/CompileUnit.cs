using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class CompileUnit : Object_T
    {
        public AttributeListCU AttributeList { get; set; }

        public class AttributeListCU : AttributeList_G
        {
            public NetworkSource_T NetworkSource { get; set; }
        }
    }
}
