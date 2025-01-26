using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class FB : Object_T, IXmlSerializable
    {
        [XmlElement("AttributeList", typeof(AttributesFb))]
        public AttributesFb Attributes { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            ID = reader.GetAttribute("ID");
            CompositionName = reader.GetAttribute("CompositionName");
            CompositionNameSpecified = CompositionName == null;

            reader.Read();

            reader.MoveToContent();
            if (reader.Name == "AttributeList")
            {
                var attributes = new AttributesFb();
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
                            var compileUnit = new SW.Blocks.CompileUnit();
                            compileUnit.ReadXml(reader);
                            items.Add(compileUnit);
                            break;
                        case "MultilingualTextItem":
                            var textItem = new MultilingualTextItem_T();
                            textItem.ReadXml(reader);
                            items.Add(textItem);
                            break;
                    }
                }

                Items = items.ToArray();
            }
            reader.Skip();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class AttributesFb : AttributeList_G, IXmlSerializable
    {
        public string AssignedProDiagFB { get; set; } = null;
        [XmlIgnore]
        public bool AssignedProDiagFBSpecified { get; set; }

        public bool? ISMultiInstanceCapable { get; set; } = null;
        [XmlIgnore]
        public bool ISMultiInstanceCapableSpecified { get; set; }

        [XmlElement("BlockTypeSupervisions", typeof(PlcBlocks.TypeSupervisions.BlockTypeSupervisions))]
        [DefaultValue("​no supervisions")]
        public PlcBlocks.TypeSupervisions.BlockTypeSupervisions Supervisions { get; set; } = null;
        [XmlIgnore]
        public bool SupervisionsSpecified { get; set; }

        [DefaultValue(false)]
        public bool IsIECCheckEnabled { get; set; } = false;
        [XmlIgnore]
        public bool IsIECCheckEnabledSpecified { get; set; }

        [DefaultValue(false)]
        public bool IsRetainMemResEnabled { get; set; } = false;
        [XmlIgnore]
        public bool IsRetainMemResEnabledSpecified { get; set; }

        [DefaultValue(0)]
        public uint MemoryReserve { get; set; } = 0;
        [XmlIgnore]
        public bool MemoryReserveSpecified { get; set; }

        [DefaultValue(0)]
        public uint RetainMemoryReserve { get; set; } = 0;
        [XmlIgnore]
        public bool RetainMemoryReserveSpecified { get; set; }

        [DefaultValue(false)]
        public bool DownloadWithoutReinit { get; set; } = false;
        [XmlIgnore]
        public bool DownloadWithoutReinitSpecified { get; set; }

        public string LibraryType { get; set; } = null;
        [XmlIgnore]
        public bool LibraryTypeSpecified { get; set; }

        public string LibraryTypeVersionGuid { get; set; } = null;
        [XmlIgnore]
        public bool LibraryTypeVersionGuidSpecified { get; set; }

        [DefaultValue(false)]
        public bool ParameterPassing { get; set; } = false;
        [XmlIgnore]
        public bool ParameterPassingSpecified { get; set; }

        [DefaultValue("")]
        public string UDABlockProperties { get; set; } = string.Empty;
        [XmlIgnore]
        public bool UDABlockPropertiesSpecified { get; set; }

        [DefaultValue(false)]
        public bool UDAEnableTagReadback { get; set; } = false;
        [XmlIgnore]
        public bool UDAEnableTagReadbackSpecified { get; set; }

        [DefaultValue(false)]
        public bool HandleErrorsWithinBlock { get; set; } = false;
        [XmlIgnore]
        public bool HandleErrorsWithinBlockSpecified { get; set; }

        public string LibraryConformanceStatus { get; set; } = null;
        [XmlIgnore]
        public bool LibraryConformanceStatusSpecified { get; set; }

        [DefaultValue(true)]
        public bool AcknowledgeErrorsRequired { get; set; } = true;
        [XmlIgnore]
        public bool AcknowledgeErrorsRequiredSpecified { get; set; }

        [DefaultValue(false)]
        public bool CreateMinimizedDB { get; set; } = false;
        [XmlIgnore]
        public bool CreateMinimizedDBSpecified { get; set; }

        public string ExtensionBlockName { get; set; } = null;
        [XmlIgnore]
        public bool ExtensionBlockNameSpecified { get; set; }

        public string GraphVersion { get; set; } = null;
        [XmlIgnore]
        public bool GraphVersionSpecified { get; set; }

        public string InitialValuesAcquisition { get; set; } = null;
        [XmlIgnore]
        public bool InitialValuesAcquisitionSpecified { get; set; }

        public string LanguageInNetworks { get; set; } = null;
        [XmlIgnore]
        public bool LanguageInNetworksSpecified { get; set; }

        [DefaultValue(false)]
        public bool LockOperatingMode { get; set; } = false;
        [XmlIgnore]
        public bool LockOperatingModeSpecified { get; set; }

        [DefaultValue(false)]
        public bool PermanentILProcessingInMANMode { get; set; } = false;
        [XmlIgnore]
        public bool PermanentILProcessingInMANModeSpecified { get; set; }

        [DefaultValue(false)]
        public bool SkipSteps { get; set; } = false;
        [XmlIgnore]
        public bool SkipStepsSpecified { get; set; }

        [DefaultValue(true)]
        public bool WithAlarmHandling { get; set; } = true;
        [XmlIgnore]
        public bool WithAlarmHandlingSpecified { get; set; }

        [DefaultValue(false)]
        public bool CheckArrayLimits { get; set; } = false;
        [XmlIgnore]
        public bool CheckArrayLimitsSpecified { get; set; }

        [DefaultValue(false)]
        public bool ExtendedStatus { get; set; } = false;
        [XmlIgnore]
        public bool ExtendedStatusSpecified { get; set; }

        [DefaultValue(true)]
        public bool DBAccessibleFromOPCUA { get; set; } = true;
        [XmlIgnore]
        public bool DBAccessibleFromOPCUASpecified {  get; set; }

        public bool? SetENOAutomatically { get; set; } = null;
        [XmlIgnore]
        public bool SetENOAutomaticallySpecified { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
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

                    case nameof(AssignedProDiagFB):
                        AssignedProDiagFB = reader.ReadContentAsString();
                        AssignedProDiagFBSpecified = true;
                        break;
                    case nameof(ISMultiInstanceCapable):
                        ISMultiInstanceCapable = reader.ReadElementContentAsBoolean();
                        ISMultiInstanceCapableSpecified = true;
                        break;
                    case nameof(Supervisions):
                        ///==============================================================
        //[XmlElement("BlockTypeSupervisions", typeof(PlcBlocks.TypeSupervisions.BlockTypeSupervisions))]
        //[DefaultValue("​no supervisions")]
        //public PlcBlocks.TypeSupervisions.BlockTypeSupervisions Supervisions { get; set; } = null;
                        SupervisionsSpecified = true;
                        break;
                    case nameof(IsIECCheckEnabled):
                        IsIECCheckEnabled = reader.ReadElementContentAsBoolean();
                        IsIECCheckEnabledSpecified = true;
                        break;
                    case nameof(IsRetainMemResEnabled):
                        IsRetainMemResEnabled = reader.ReadElementContentAsBoolean();
                        IsRetainMemResEnabledSpecified = true;
                        break;
                    case nameof(MemoryReserve):
                        MemoryReserve = (uint)reader.ReadElementContentAsInt();
                        MemoryReserveSpecified = true;
                        break;
                    case nameof(RetainMemoryReserve):
                        RetainMemoryReserve = (uint)reader.ReadElementContentAsInt();
                        RetainMemoryReserveSpecified = true;
                        break;
                    case nameof(DownloadWithoutReinit):
                        DownloadWithoutReinit = reader.ReadElementContentAsBoolean();
                        DownloadWithoutReinitSpecified = true;
                        break;
                    case nameof(LibraryType):
                        LibraryType = reader.ReadElementContentAsString();
                        LibraryTypeSpecified = true;
                        break;
                    case nameof(LibraryTypeVersionGuid):
                        LibraryTypeVersionGuid = reader.ReadElementContentAsString();
                        LibraryTypeVersionGuidSpecified = true;
                        break;
                    case nameof(ParameterPassing):
                        ParameterPassing = reader.ReadElementContentAsBoolean();
                        ParameterPassingSpecified = true;
                        break;
                    case nameof(UDABlockProperties):
                        UDABlockProperties = reader.ReadElementContentAsString();
                        UDABlockPropertiesSpecified = true;
                        break;
                    case nameof(UDAEnableTagReadback):
                        UDAEnableTagReadback = reader.ReadElementContentAsBoolean();
                        UDAEnableTagReadbackSpecified = true;
                        break;
                    case nameof(HandleErrorsWithinBlock):
                        HandleErrorsWithinBlock = reader.ReadElementContentAsBoolean();
                        HandleErrorsWithinBlockSpecified = true;
                        break;
                    case nameof(LibraryConformanceStatus):
                        LibraryConformanceStatus = reader.ReadElementContentAsString();
                        LibraryConformanceStatusSpecified = true;
                        break;
                    case nameof(AcknowledgeErrorsRequired):
                        AcknowledgeErrorsRequired = reader.ReadElementContentAsBoolean();
                        AcknowledgeErrorsRequiredSpecified = true;
                        break;
                    case nameof(CreateMinimizedDB):
                        CreateMinimizedDB = reader.ReadElementContentAsBoolean();
                        CreateMinimizedDBSpecified = true;
                        break;
                    case nameof(ExtensionBlockName):
                        ExtensionBlockName = reader.ReadElementContentAsString();
                        ExtensionBlockNameSpecified = true;
                        break;
                    case nameof(GraphVersion):
                        GraphVersion = reader.ReadElementContentAsString();
                        GraphVersionSpecified = true;
                        break;
                    case nameof(InitialValuesAcquisition):
                        InitialValuesAcquisition = reader.ReadElementContentAsString();
                        InitialValuesAcquisitionSpecified = true;
                        break;
                    case nameof(LanguageInNetworks):
                        LanguageInNetworks = reader.ReadElementContentAsString();
                        LanguageInNetworksSpecified = true;
                        break;
                    case nameof(LockOperatingMode):
                        LockOperatingMode = reader.ReadElementContentAsBoolean();
                        LockOperatingModeSpecified = true;
                        break;
                    case nameof(PermanentILProcessingInMANMode):
                        PermanentILProcessingInMANMode = reader.ReadElementContentAsBoolean();
                        PermanentILProcessingInMANModeSpecified = true;
                        break;
                    case nameof(SkipSteps):
                        SkipSteps = reader.ReadElementContentAsBoolean();
                        SkipStepsSpecified = true;
                        break;
                    case nameof(WithAlarmHandling):
                        WithAlarmHandling = reader.ReadElementContentAsBoolean();
                        WithAlarmHandlingSpecified = true;
                        break;
                    case nameof(CheckArrayLimits):
                        CheckArrayLimits = reader.ReadElementContentAsBoolean();
                        CheckArrayLimitsSpecified = true;
                        break;
                    case nameof(ExtendedStatus):
                        ExtendedStatus = reader.ReadElementContentAsBoolean();
                        ExtendedStatusSpecified = true;
                        break;
                    case nameof(DBAccessibleFromOPCUA):
                        DBAccessibleFromOPCUA = reader.ReadElementContentAsBoolean();
                        DBAccessibleFromOPCUASpecified = true;
                        break;
                    case nameof(SetENOAutomatically):
                        SetENOAutomatically = reader.ReadElementContentAsBoolean();
                        SetENOAutomaticallySpecified = true;
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
