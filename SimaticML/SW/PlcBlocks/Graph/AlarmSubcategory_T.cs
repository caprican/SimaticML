using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IAlarmSubcategory
    {
        ushort Id { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmSubcategory1Interlock", IsNullable = false)]
    public class AlarmSubcategory_T : Object_G, IAlarmSubcategory
    {
        [XmlAttribute]
        public ushort Id { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Id):
                        Id = (ushort)reader.ReadContentAsInt();
                        break;

                    default:
                        reader.Skip();
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
