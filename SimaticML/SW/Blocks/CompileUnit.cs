using System;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    public class CompileUnit : Object_T
    {
        public AttributeListCU AttributeList { get; set; }

        public class AttributeListCU : AttributeList_G
        {
            public NetworkSource_T NetworkSource { get; set; }
        }
    }
}
