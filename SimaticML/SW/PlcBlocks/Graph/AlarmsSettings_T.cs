using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IAlarmsSettings
    {
        IAlarmSupervisionCategories AlarmSupervisionCategories { get; set; }
        IAlarmCategory AlarmInterlockCategory { get; set; }
        IAlarmCategory AlarmWarningCategory { get; set; }
    }

    public interface IAlarmsSettings_v4 : IAlarmsSettings
    {
        IAlarmSubcategory AlarmSubcategory1Interlock { get; set; }
        IAlarmSubcategory AlarmSubcategory1Supervision { get; set; }
        IAlarmSubcategory AlarmSubcategory1Warning { get; set; }

        IAlarmSubcategory AlarmSubcategory2Interlock { get; set; }
        IAlarmSubcategory AlarmSubcategory2Supervision { get; set; }
        IAlarmSubcategory AlarmSubcategory2Warning { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmsSettings", IsNullable = false)]
    public class AlarmsSettings_T : Object_G, IAlarmsSettings
    {
        public IAlarmSupervisionCategories AlarmSupervisionCategories { get; set; }

        public IAlarmCategory AlarmInterlockCategory { get; set; }

        public IAlarmCategory AlarmWarningCategory { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AlarmSupervisionCategories":
                            var alarmSupervisionCategories = new AlarmSupervisionCategories_T();
                            alarmSupervisionCategories.ReadXml(reader);
                            AlarmSupervisionCategories = alarmSupervisionCategories;
                            break;
                        case "AlarmInterlockCategory":
                            var alarmInterlockCategory = new AlarmCategory_T();
                            alarmInterlockCategory.ReadXml(reader);
                            AlarmInterlockCategory = alarmInterlockCategory;
                            break;
                        case "AlarmWarningCategory":
                            var alarmWarningCategory = new AlarmCategory_T();
                            alarmWarningCategory.ReadXml(reader);
                            AlarmWarningCategory = alarmWarningCategory;
                            break;
                    }
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmsSettings", IsNullable = false)]
    public class AlarmsSettings_T_v2 : AlarmsSettings_T, IAlarmsSettings
    {
        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AlarmSupervisionCategories":
                            var alarmSupervisionCategories = new AlarmSupervisionCategories_T_v2();
                            alarmSupervisionCategories.ReadXml(reader);
                            AlarmSupervisionCategories = alarmSupervisionCategories;
                            break;
                        case "AlarmInterlockCategory":
                            var alarmInterlockCategory = new AlarmCategory_T();
                            alarmInterlockCategory.ReadXml(reader);
                            AlarmInterlockCategory = alarmInterlockCategory;
                            break;
                        case "AlarmWarningCategory":
                            var alarmWarningCategory = new AlarmCategory_T();
                            alarmWarningCategory.ReadXml(reader);
                            AlarmWarningCategory = alarmWarningCategory;
                            break;
                    }
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmsSettings", IsNullable = false)]
    public class AlarmsSettings_T_v4 : AlarmsSettings_T_v2, IAlarmsSettings_v4
    {
        public IAlarmSubcategory AlarmSubcategory1Interlock { get; set; }

        public IAlarmSubcategory AlarmSubcategory2Interlock { get; set; }

        public IAlarmSubcategory AlarmSubcategory1Supervision { get; set; }

        public IAlarmSubcategory AlarmSubcategory2Supervision { get; set; }

        public IAlarmSubcategory AlarmSubcategory1Warning { get; set; }

        public IAlarmSubcategory AlarmSubcategory2Warning { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AlarmSupervisionCategories":
                            var alarmSupervisionCategories = new AlarmSupervisionCategories_T_v2();
                            alarmSupervisionCategories.ReadXml(reader);
                            AlarmSupervisionCategories = alarmSupervisionCategories;
                            break;
                        case "AlarmInterlockCategory":
                            var alarmInterlockCategory = new AlarmCategory_T();
                            alarmInterlockCategory.ReadXml(reader);
                            AlarmInterlockCategory = alarmInterlockCategory;
                            break;
                        case "AlarmWarningCategory":
                            var alarmWarningCategory = new AlarmCategory_T();
                            alarmWarningCategory.ReadXml(reader);
                            AlarmWarningCategory = alarmWarningCategory;
                            break;
                        case "AlarmSubcategory1Interlock":
                            var alarmSubcategory1Interlock = new AlarmSubcategory_T();
                            alarmSubcategory1Interlock.ReadXml(reader);
                            AlarmSubcategory1Interlock = alarmSubcategory1Interlock;
                            break;
                        case "AlarmSubcategory2Interlock":
                            var alarmSubcategory2Interlock = new AlarmSubcategory_T();
                            alarmSubcategory2Interlock.ReadXml(reader);
                            AlarmSubcategory2Interlock = alarmSubcategory2Interlock;
                            break;
                        case "AlarmSubcategory1Supervision":
                            var alarmSubcategory1Supervision = new AlarmSubcategory_T();
                            alarmSubcategory1Supervision.ReadXml(reader);
                            AlarmSubcategory1Supervision = alarmSubcategory1Supervision;
                            break;
                        case "AlarmSubcategory2Supervision":
                            var alarmSubcategory2Supervision = new AlarmSubcategory_T();
                            alarmSubcategory2Supervision.ReadXml(reader);
                            AlarmSubcategory2Supervision = alarmSubcategory2Supervision;
                            break;
                        case "AlarmSubcategory1Warning":
                            var alarmSubcategory1Warning = new AlarmSubcategory_T();
                            alarmSubcategory1Warning.ReadXml(reader);
                            AlarmSubcategory1Warning = alarmSubcategory1Warning;
                            break;
                        case "AlarmSubcategory2Warning":
                            var alarmSubcategory2Warning = new AlarmSubcategory_T();
                            alarmSubcategory2Warning.ReadXml(reader);
                            AlarmSubcategory2Warning = alarmSubcategory2Warning;
                            break;
                    }
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
