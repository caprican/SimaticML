using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataAxis
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Axis/v1")]
    public enum ConnectOption_TE
    {
        Default,
        AllowAllModules
    }
}
