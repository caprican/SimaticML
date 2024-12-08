using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <summary>
    /// Not allowed in STL
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true)]
    //[XmlRoot(Namespace = "", IsNullable = false)]
    public class Comment : Comment_T
    {
    }
}
