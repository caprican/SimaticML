﻿using System;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public enum BoundaryConditions
    {
        NoConstraint,
        FirstDerivative
    }
}
