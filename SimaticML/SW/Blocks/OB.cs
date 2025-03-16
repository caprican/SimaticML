using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class OB : Object_T, IXmlSerializable
    {
        [XmlElement("AttributeList", typeof(AttributesOb))]
        public AttributesOb Attributes { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(ID):
                        ID = reader.ReadContentAsString();
                        break;

                    case nameof(CompositionName):
                        CompositionName = reader.ReadContentAsString();
                        CompositionNameSpecified = true;
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Read();
            reader.MoveToContent();
            if (reader.Name == "AttributeList")
            {
                var attributes = new AttributesOb();
                attributes.ReadXml(reader);
                Attributes = attributes;
            }

            reader.MoveToContent();
            if (reader.Name == "ObjectList")
            {
                reader.Read();

                var items = new List<Object_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "MultilingualText":
                            var text = new MultilingualText_T();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "SW.Blocks.CompileUnit":
                            var compileUnit = new CompileUnit();
                            compileUnit.ReadXml(reader);
                            items.Add(compileUnit);
                            break;
                        case "MultilingualTextItem":
                            var textItem = new MultilingualTextItem_T();
                            textItem.ReadXml(reader);
                            items.Add(textItem);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class AttributesOb : AttributeList_G, IXmlSerializable
    {
        public long? ApplicationCycle { get; set; } = null;
        [XmlIgnore]
        public bool ApplicationCycleSpecified { get; set; }

        public bool? AutomaticMinimum { get; set; } = null;
        [XmlIgnore]
        public bool AutomaticMinimumSpecified { get; set; }

        public string ConstantName { get; set; } = null;
        [XmlIgnore]
        public bool ConstantNameSpecified { get; set; }

        public long? CycleTimeDistributedIO { get; set; } = null;
        [XmlIgnore]
        public bool CycleTimeDistributedIOSpecified { get; set; }

        public long? CyclicApplicationCycleTime { get; set; } = null;
        [XmlIgnore]
        public bool CyclicApplicationCycleTimeSpecified { get; set; }

        [DefaultValue(100_000)]
        public int CyclicTime { get; set; } = 100_000;
        [XmlIgnore]
        public bool CyclicTimeSpecified { get; set; }

        //[DefaultValue(Cyclic)]
        //public OBDataExchangeMode DataExchangeMode { get; set; }

        public double? DelayTime { get; set; } = null;
        [XmlIgnore]
        public bool DelayTimeSpecified { get; set; }

        public string DistributedIOName { get; set; } = null;
        [XmlIgnore]
        public bool DistributedIONameSpecified { get; set; }

        public int? DistributedIONumber { get; set; } = null;
        [XmlIgnore]
        public bool DistributedIONumberSpecified { get; set; }

        public bool? EnableTimeError { get; set; } = null;
        [XmlIgnore]
        public bool EnableTimeErrorSpecified { get; set; }

        public string EventClass { get; set; } = null;
        [XmlIgnore]
        public bool EventClassSpecified { get; set; }

        public int? EventsToBeQueued { get; set; } = null;
        [XmlIgnore]
        public bool EventsToBeQueuedSpecified { get; set; }

        public int? EventThresholdForTimeError { get; set; } = null;
        [XmlIgnore]
        public bool EventThresholdForTimeErrorSpecified { get; set; }

        //[DefaultValue(Never)]
        //public OBExecution Execution { get; set; }
        //public bool ExecutionSpecified { get; set; }

        public long? Factor { get; set; } = null;
        [XmlIgnore]
        public bool FactorSpecified { get; set; }

        [DefaultValue(0)]
        public int PhaseOffset { get; set; } = 0;
        [XmlIgnore]
        public bool PhaseOffsetSpecified { get; set; }

        public int? PriorityNumber { get; set; } = null;
        [XmlIgnore]
        public bool PriorityNumberSpecified { get; set; }

        public uint? ProcessImagePartNumber { get; set; } = null;
        [XmlIgnore]
        public bool ProcessImagePartNumberSpecified { get; set; }

        public bool? ReportEvents { get; set; } = null;
        [XmlIgnore]
        public bool ReportEventsSpecified { get; set; }

        public string SecondaryType { get; set; } = null;
        [XmlIgnore]
        public bool SecondaryTypeSpecified { get; set; }

        [DefaultValue("​1/1/2012")]
        public DateTime StartDate { get; set; } = new DateTime(2012, 1, 1);
        [XmlIgnore]
        public bool StartDateSpecified { get; set; }

        public long? SynchronousApplicationCycleTime { get; set; } = null;
        [XmlIgnore]
        public bool SynchronousApplicationCycleTimeSpecified { get; set; }

        //[DefaultValue(System)]
        //public OBTimeMode TimeMode { get; set; }
        //[XmlIgnore]
        //public bool TimeModeSpecified { get; set; }

        [DefaultValue("​12:00 AM")]
        public TimeSpan TimeOfDay { get; set; } = new TimeSpan(0, 0, 0);
        [XmlIgnore]
        public bool TimeOfDaySpecified { get; set; }

        [DefaultValue("0xffff")]
        public uint? TransformationDBNumber { get; set; } = null;
        [XmlIgnore]
        public bool TransformationDBNumberSpecified { get; set; }

        [DefaultValue(false)]
        public bool HandleErrorsWithinBlock { get; set; } = false;
        [XmlIgnore]
        public bool HandleErrorsWithinBlockSpecified { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Read();

            while (reader.MoveToContent() == XmlNodeType.Element)
            {
                switch (reader.Name)
                {
                    #region Common attributes for all blocks
                    case nameof(AutoNumber):
                        AutoNumber = reader.ReadElementContentAsBoolean();
                        AutoNumberSpecified = true;
                        break;
                    case nameof(CodeModifiedDate):
                        CodeModifiedDate = reader.ReadElementContentAsDateTime(); ;
                        CodeModifiedDateSpecified = true;
                        break;
                    case nameof(CompileDate):
                        CompileDate = reader.ReadElementContentAsDateTime();
                        CompileDateSpecified = true;
                        break;
                    case nameof(CreationDate):
                        CreationDate = reader.ReadElementContentAsDateTime();
                        CreationDateSpecified = true;
                        break;
                    case nameof(HeaderAuthor):
                        HeaderAuthor = reader.ReadInnerXml();
                        HeaderAuthorSpecified = true;
                        break;
                    case nameof(HeaderFamily):
                        HeaderFamily = reader.ReadInnerXml();
                        HeaderFamilySpecified = true;
                        break;
                    case nameof(HeaderName):
                        HeaderName = reader.ReadInnerXml();
                        HeaderNameSpecified = true;
                        break;
                    case nameof(HeaderVersion):
                        HeaderVersion = reader.ReadInnerXml();
                        HeaderVersionSpecified = true;
                        break;
                    case nameof(Interface):
                        Interface = new SW.Interface_T();
                        Interface.ReadXml(reader);
                        InterfaceSpecified = true;
                        break;
                    case nameof(InterfaceModifiedDate):
                        InterfaceModifiedDate = reader.ReadElementContentAsDateTime();
                        InterfaceModifiedDateSpecified = true;
                        break;
                    case nameof(IsConsistent):
                        IsConsistent = reader.ReadElementContentAsBoolean();
                        IsConsistentSpecified = true;
                        break;
                    case nameof(IsKnowHowProtected):
                        IsKnowHowProtected = reader.ReadElementContentAsBoolean();
                        IsKnowHowProtectedPrecified = true;
                        break;
                    case nameof(IsWriteProtected):
                        IsWriteProtected = reader.ReadElementContentAsBoolean();
                        IsWriteProtectedSpecified = true;
                        break;
                    case nameof(MemoryLayout):
                        Enum.TryParse<MemoryLayout_TE>(reader.ReadInnerXml(), out var memoryLayout);
                        MemoryLayout = memoryLayout;
                        MemoryLayoutSpecified = true;
                        break;
                    case nameof(ModifiedDate):
                        ModifiedDate = reader.ReadElementContentAsDateTime();
                        ModifiedDateSpecified = true;
                        break;
                    case nameof(Name):
                        Name = reader.ReadInnerXml();
                        NameSpecified = true;
                        break;
                    case nameof(Number):
                        NumberSpecified = true;
                        Number = reader.ReadElementContentAsInt();
                        break;
                    case nameof(ParameterModified):
                        ParameterModified = reader.ReadElementContentAsDateTime();
                        ParameterModifiedSpecified = true;
                        break;
                    case nameof(PLCSimAdvancedSupport):
                        PLCSimAdvancedSupportSpecified = true;
                        PLCSimAdvancedSupport = reader.ReadElementContentAsBoolean();
                        break;
                    case nameof(ProgrammingLanguage):
                        Enum.TryParse<ProgrammingLanguage_TE>(reader.ReadInnerXml(), out var programmingLanguage);
                        ProgrammingLanguage = programmingLanguage;
                        ProgrammingLanguageSpecified = true;
                        break;
                    case nameof(StructureModified):
                        StructureModified = reader.ReadElementContentAsDateTime();
                        StructureModifiedSpecified = true;
                        break;
                    #endregion

                    case nameof(ApplicationCycle):
                        ApplicationCycle = reader.ReadElementContentAsLong();
                        ApplicationCycleSpecified = true;
                        break;
                    case nameof(AutomaticMinimum):
                        AutomaticMinimum = reader.ReadElementContentAsBoolean();
                        AutomaticMinimumSpecified = true;
                        break;
                    case nameof(ConstantName):
                        ConstantName = reader.ReadElementContentAsString();
                        ConstantNameSpecified = true;
                        break;
                    case nameof(CycleTimeDistributedIO):
                        CycleTimeDistributedIO = reader.ReadElementContentAsLong();
                        CycleTimeDistributedIOSpecified = true;
                        break;
                    case nameof(CyclicApplicationCycleTime):
                        CyclicApplicationCycleTime = reader.ReadElementContentAsLong();
                        CyclicApplicationCycleTimeSpecified = true;
                        break;
                    case nameof(CyclicTime):
                        CyclicTime = reader.ReadElementContentAsInt();
                        CyclicTimeSpecified = true;
                        break;
                    //case nameof(DataExchangeMode):
                    //    throw new NotImplementedException();
                    //    break;
                    case nameof(DelayTime):
                        DelayTime = reader.ReadElementContentAsDouble();
                        DelayTimeSpecified = true;
                        break;
                    case nameof(DistributedIOName):
                        DistributedIOName = reader.ReadElementContentAsString();
                        DistributedIONameSpecified = true;
                        break;
                    case nameof(DistributedIONumber):
                        DistributedIONumber = reader.ReadElementContentAsInt();
                        DistributedIONumberSpecified = true;
                        break;
                    case nameof(EnableTimeError):
                        EnableTimeError = reader.ReadElementContentAsBoolean();
                        EnableTimeErrorSpecified = true;
                        break;
                    case nameof(EventClass):
                        EventClass = reader.ReadElementContentAsString();
                        EventClassSpecified = true;
                        break;
                    case nameof(EventsToBeQueued):
                        EventsToBeQueued = reader.ReadElementContentAsInt();
                        EventsToBeQueuedSpecified = true;
                        break;
                    case nameof(EventThresholdForTimeError):
                        EventThresholdForTimeError = reader.ReadElementContentAsInt();
                        EventThresholdForTimeErrorSpecified = true;
                        break;
                    //case nameof(Execution):
                    //    throw new NotImplementedException();
                    //    break;
                    case nameof(Factor):
                        Factor = reader.ReadElementContentAsLong();
                        FactorSpecified = true;
                        break;
                    case nameof(PhaseOffset):
                        PhaseOffset = reader.ReadElementContentAsInt();
                        PhaseOffsetSpecified = true;
                        break;
                    case nameof(PriorityNumber):
                        PriorityNumber = reader.ReadElementContentAsInt();
                        PriorityNumberSpecified = true;
                        break;
                    case nameof(ProcessImagePartNumber):
                        ProcessImagePartNumber = (uint)reader.ReadElementContentAsInt();
                        ProcessImagePartNumberSpecified = true;
                        break;
                    case nameof(ReportEvents):
                        ReportEvents = reader.ReadElementContentAsBoolean();
                        ReportEventsSpecified = true;
                        break;
                    case nameof(SecondaryType):
                        SecondaryType = reader.ReadElementContentAsString();
                        SecondaryTypeSpecified = true;
                        break;
                    case nameof(StartDate):
                        StartDate = reader.ReadElementContentAsDateTime();
                        StartDateSpecified = true;
                        break;
                    case nameof(SynchronousApplicationCycleTime):
                        SynchronousApplicationCycleTime = reader.ReadElementContentAsLong();
                        SynchronousApplicationCycleTimeSpecified = true;
                        break;
                    //case nameof(TimeMode):
                    //    throw new NotImplementedException();
                    //    break;
                    case nameof(TimeOfDay):
                        TimeOfDay = reader.ReadElementContentAsDateTime().TimeOfDay;
                        TimeOfDaySpecified = true;
                        break;
                    case nameof(TransformationDBNumber):
                        TransformationDBNumber = (uint)reader.ReadElementContentAsInt();
                        TransformationDBNumberSpecified = true;
                        break;
                    case nameof(HandleErrorsWithinBlock):
                        HandleErrorsWithinBlock = reader.ReadElementContentAsBoolean();
                        HandleErrorsWithinBlockSpecified = true;
                        break;
                    default:
                        reader.Skip();
                        break;
                }

            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
