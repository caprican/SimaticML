using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class OB : Object_T
    {
        public AttributeOB AttributeList { get; set; }

        public class AttributeOB : AttributeList_G
        {
            public AttributeOB()
            {
                CyclicTime = 100000;
                PhaseOffset = 0;

                StartDate = new DateTime(2012, 1, 1);
                //TimeOfDay = new DateTime(0, 0, 0);

                HandleErrorsWithinBlock = false;
            }

            public long ApplicationCycle { get; set; }
            [XmlIgnore]
            public bool ApplicationCycleSpecified { get; set; }

            public bool AutomaticMinimum { get; set; }
            [XmlIgnore]
            public bool AutomaticMinimumSpecified { get; set; }

            public string ConstantName { get; set; }
            [XmlIgnore]
            public bool ConstantNameSpecified { get; set; }

            public long CycleTimeDistributedIO { get; set; }
            [XmlIgnore]
            public bool CycleTimeDistributedIOSpecified { get; set; }

            public long CyclicApplicationCycleTime { get; set; }
            [XmlIgnore]
            public bool CyclicApplicationCycleTimeSpecified { get; set; }

            [DefaultValue(100000)]
            public int CyclicTime { get; set; }
            [XmlIgnore]
            public bool CyclicTimeSpecified { get; set; }

            //[DefaultValue(Cyclic)]
            //public OBDataExchangeMode DataExchangeMode { get; set; }

            public double DelayTime { get; set; }
            [XmlIgnore]
            public bool DelayTimeSpecified { get; set; }

            public string DistributedIOName { get;set; }
            [XmlIgnore]
            public bool DistributedIONameSpecified { get; set; }

            public int DistributedIONumber { get; set; }
            [XmlIgnore]
            public bool DistributedIONumberSpecified { get; set; }

            public bool EnableTimeError { get; set; }
            [XmlIgnore]
            public bool EnableTimeErrorSpecified { get; set; }

            public string EventClass { get; set; }
            [XmlIgnore]
            public bool EventClassSpecified { get; set; }

            public int EventsToBeQueued { get; set; }
            [XmlIgnore]
            public bool EventsToBeQueuedSpecified { get; set; }

            public int EventThresholdForTimeError { get; set; }
            [XmlIgnore]
            public bool EventThresholdForTimeErrorSpecified { get; set; }

            //[DefaultValue(Never)]
            //public OBExecution Execution { get; set; }
            //public bool ExecutionSpecified { get; set; }

            public long Factor { get; set; }
            [XmlIgnore]
            public bool FactorSpecified { get; set; }

            [DefaultValue(0)]
            public int PhaseOffset { get;set; }
            [XmlIgnore]
            public bool PhaseOffsetSpecified { get; set; }

            public int PriorityNumber { get; set; }
            [XmlIgnore]
            public bool PriorityNumberSpecified { get; set; }

            public uint ProcessImagePartNumber { get; set; }
            [XmlIgnore]
            public bool ProcessImagePartNumberSpecified { get; set; }

            public bool ReportEvents { get; set; }
            [XmlIgnore]
            public bool ReportEventsSpecified { get; set; }

            public string SecondaryType { get; set; }
            [XmlIgnore]
            public bool SecondaryTypeSpecified { get; set; }

            [DefaultValue("​1/1/2012")]
            public DateTime StartDate { get; set; }
            [XmlIgnore]
            public bool StartDateSpecified { get; set; }

            public long SynchronousApplicationCycleTime { get; set; }
            [XmlIgnore]
            public bool SynchronousApplicationCycleTimeSpecified { get; set; }

            //[DefaultValue(System)]
            //public OBTimeMode TimeMode { get; set; }
            //[XmlIgnore]
            //public bool TimeModeSpecified { get; set; }

            [DefaultValue("​12:00 AM")]
            public DateTime TimeOfDay { get; set; }
            [XmlIgnore]
            public bool TimeOfDaySpecified { get; set; }

            [DefaultValue("0xffff")]
            public uint TransformationDBNumber { get; set; }
            [XmlIgnore]
            public bool TransformationDBNumberSpecified { get; set; }

            [DefaultValue(false)]
            public bool HandleErrorsWithinBlock { get; set; }
            [XmlIgnore]
            public bool HandleErrorsWithinBlockSpecified { get; set; }
        }
    }
}
