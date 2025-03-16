using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IAlarmSupervisionCategories
    {
        IAlarmSupervisionCategory[] AlarmSupervisionCategories { get; set; }
    }
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmSupervisionCategories", IsNullable = false)]
    public class AlarmSupervisionCategories_T : Object_G, IAlarmSupervisionCategories
    {
        [XmlElement("AlarmSupervisionCategory")]
        public IAlarmSupervisionCategory[] AlarmSupervisionCategories { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var alarms = new List<IAlarmSupervisionCategory>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AlarmSupervisionCategory":
                            var alarmSupervisionCategory = new AlarmSupervisionCategory_T();
                            alarmSupervisionCategory.ReadXml(reader);
                            alarms.Add(alarmSupervisionCategory);
                            break;
                    }
                }
                if (alarms.Count > 0) AlarmSupervisionCategories = alarms.ToArray();
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmSupervisionCategories", IsNullable = false)]
    public class AlarmSupervisionCategories_T_v2 : AlarmSupervisionCategories_T, IAlarmSupervisionCategories
    {
        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var alarms = new List<IAlarmSupervisionCategory>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AlarmSupervisionCategory":
                            var alarmSupervisionCategory = new AlarmSupervisionCategory_T_v2();
                            alarmSupervisionCategory.ReadXml(reader);
                            alarms.Add(alarmSupervisionCategory);
                            break;
                    }
                }
                if (alarms.Count > 0) AlarmSupervisionCategories = alarms.ToArray();
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
