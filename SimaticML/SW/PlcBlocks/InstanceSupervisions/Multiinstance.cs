﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.InstanceSupervisions => SW.Common</item>
    /// <item>SW.PlcBlocks.InstanceSupervisions_v2 => SW.Common_v2</item>
    /// <item>SW.PlcBlocks.InstanceSupervisions_v3 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class Multiinstance : Object_G
    {
        [XmlAttribute]
        public string Name { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                }
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
