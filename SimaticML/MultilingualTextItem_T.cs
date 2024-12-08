using System;
using System.Diagnostics;

namespace SimaticML
{
    [Serializable]
    
    public class MultilingualTextItem_T : Object_T
    {
        public Attribute_T AttributeList { get; set; }


        [DebuggerDisplay("{Text}")]
        public class Attribute_T
        {
            public string Culture { get; set; }
            public string Text { get; set; }
        }
    }
}
