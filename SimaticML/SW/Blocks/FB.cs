using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.PlcBlocks.TypeSupervisions;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class FB : Object_T
    {
        public AttributeListFB AttributeList { get; set; }

        public class AttributeListFB : AttributeList_G
        {
            public AttributeListFB() : base()
            {
                //Supervisions = "​no supervisions";
                IsIECCheckEnabled = false;
                IsRetainMemResEnabled = false;
                MemoryReserve = 0;
                RetainMemoryReserve = 0;

                DownloadWithoutReinit = false;

                ParameterPassing = false;

                UDABlockProperties = "";
                UDAEnableTagReadback = false;
                AcknowledgeErrorsRequired = true;
                CreateMinimizedDB = false;
                LockOperatingMode = false;
                PermanentILProcessingInMANMode = false;
                SkipSteps = false;

                WithAlarmHandling = true;
                CheckArrayLimits = false;
                ExtendedStatus = false;

                HandleErrorsWithinBlock = false;
                DBAccessibleFromOPCUA = true;
            }

            public string AssignedProDiagFB { get; set; }
            [XmlIgnore]
            public bool AssignedProDiagFBSpecified { get; set; }

            public bool ISMultiInstanceCapable { get; set; }
            [XmlIgnore]
            public bool ISMultiInstanceCapableSpecified { get; set; }

            //[XmlElement("BlockTypeSupervisions", typeof(PlcBlocks.TypeSupervisions.BlockTypeSupervisions))]
            //[DefaultValue("​no supervisions")]
            //public object Supervisions { get; set; }
            //[XmlIgnore]
            //public bool SupervisionsSpecified { get; set; }

            [DefaultValue(false)]
            public bool IsIECCheckEnabled { get; set; }
            [XmlIgnore]
            public bool IsIECCheckEnabledSpecified { get; set; }

            [DefaultValue(false)]
            public bool IsRetainMemResEnabled { get; set; }
            [XmlIgnore]
            public bool IsRetainMemResEnabledSpecified { get; set; }

            [DefaultValue(0)]
            public uint MemoryReserve { get; set; }
            [XmlIgnore]
            public bool MemoryReserveSpecified { get; set; }

            [DefaultValue(0)]
            public uint RetainMemoryReserve { get; set; }
            [XmlIgnore]
            public bool RetainMemoryReserveSpecified { get; set; }

            [DefaultValue(false)]
            public bool DownloadWithoutReinit { get; set; }
            [XmlIgnore]
            public bool DownloadWithoutReinitSpecified { get; set; }

            public string LibraryType { get; set; }
            [XmlIgnore]
            public bool LibraryTypeSpecified { get; set; }

            public string LibraryTypeVersionGuid { get; set; }
            [XmlIgnore]
            public bool LibraryTypeVersionGuidSpecified { get; set; }

            [DefaultValue(false)]
            public bool ParameterPassing { get; set; }
            [XmlIgnore]
            public bool ParameterPassingSpecified { get; set; }

            [DefaultValue("")]
            public string UDABlockProperties { get; set; }
            [XmlIgnore]
            public bool UDABlockPropertiesSpecified { get; set; }

            [DefaultValue(false)]
            public bool UDAEnableTagReadback { get; set; }
            [XmlIgnore]
            public bool UDAEnableTagReadbackSpecified { get; set; }

            [DefaultValue(false)]
            public bool HandleErrorsWithinBlock { get; set; }
            [XmlIgnore]
            public bool HandleErrorsWithinBlockSpecified { get; set; }

            public string LibraryConformanceStatus { get; set; }
            [XmlIgnore]
            public bool LibraryConformanceStatusSpecified { get; set; }

            [DefaultValue(true)]
            public bool AcknowledgeErrorsRequired { get; set; }
            [XmlIgnore]
            public bool AcknowledgeErrorsRequiredSpecified { get; set; }

            [DefaultValue(false)]
            public bool CreateMinimizedDB { get; set; }
            [XmlIgnore]
            public bool CreateMinimizedDBSpecified { get; set; }

            public string ExtensionBlockName { get; set; }
            [XmlIgnore]
            public bool ExtensionBlockNameSpecified { get; set; }

            public string GraphVersion { get; set; }
            [XmlIgnore]
            public bool GraphVersionSpecified { get; set; }

            public string InitialValuesAcquisition { get; set; }
            [XmlIgnore]
            public bool InitialValuesAcquisitionSpecified { get; set; }

            public string LanguageInNetworks { get; set; }
            [XmlIgnore]
            public bool LanguageInNetworksSpecified { get; set; }

            [DefaultValue(false)]
            public bool LockOperatingMode { get; set; }
            [XmlIgnore]
            public bool LockOperatingModeSpecified { get; set; }

            [DefaultValue (false)]
            public bool PermanentILProcessingInMANMode { get; set; }
            [XmlIgnore]
            public bool PermanentILProcessingInMANModeSpecified { get; set; }

            [DefaultValue(false)]
            public bool SkipSteps { get; set; }
            [XmlIgnore]
            public bool SkipStepsSpecified { get; set; }

            [DefaultValue(true)]
            public bool WithAlarmHandling { get; set; }
            [XmlIgnore]
            public bool WithAlarmHandlingSpecified { get; set; }

            [DefaultValue(false)]
            public bool CheckArrayLimits { get; set; }
            [XmlIgnore]
            public bool CheckArrayLimitsSpecified { get; set; }

            [DefaultValue(false)]
            public bool ExtendedStatus { get; set; }
            [XmlIgnore]
            public bool ExtendedStatusSpecified { get; set; }

            [DefaultValue(true)]
            public bool DBAccessibleFromOPCUA { get; set; }
            [XmlIgnore]
            public bool DBAccessibleFromOPCUASpecified {  get; set; }

            public bool SetENOAutomatically { get; set; }
            [XmlIgnore]
            public bool SetENOAutomaticallySpecified { get; set; }
        }
    }
}
