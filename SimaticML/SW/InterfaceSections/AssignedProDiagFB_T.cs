﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AssignedProDiagFB", IsNullable = false)]
    public class AssignedProDiagFB_T : Object_G
    {
        [XmlText]
        public string Value { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.Read();
            Value = reader.Value;
            reader.Read();

            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
