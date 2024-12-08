using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    ///<remarks>Add on v4</remarks>
    [Serializable]
    [XmlRoot("AlarmSubcategory1Interlock", Namespace = "", IsNullable = false)]
    public class AlarmSubcategory_T
    {
        [XmlAttribute]
        public ushort Id { get; set; }
    }
}
