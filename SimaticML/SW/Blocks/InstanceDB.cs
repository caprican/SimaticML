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
    public class InstanceDB : Object_T, IXmlSerializable
    {
        [XmlElement("AttributeList", typeof(AttributesIDB))]
        public AttributesIDB Attributes { get; set; }

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
                        break;
                }
            }

            reader.Read();
            reader.MoveToContent();
            if (reader.Name == "AttributeList")
            {
                var attributes = new AttributesIDB();
                attributes.ReadXml(reader);
                Attributes = attributes;
            }

            reader.MoveToContent();
            if (reader.Name == "ObjectList")
            {
                reader.Read();

                var items = Helpers.ObjectListHelper.Read(reader);
                if (items.Length > 0) Items = items;
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class AttributesIDB : AttributeList_G, IXmlSerializable
    {
        [DefaultValue(false)]
        public bool DownloadWithoutReinit { get; set; } = false;
        [XmlIgnore]
        public bool DownloadWithoutReinitSpecified { get; set; }

        [DefaultValue("")]
        public string UDABlockProperties { get; set; } = string.Empty;
        [XmlIgnore]
        public bool UDABlockPropertiesSpecified { get; set; }

        [DefaultValue(false)]
        public bool UDAEnableTagReadback { get; set; } = false;
        [XmlIgnore]
        public bool UDAEnableTagReadbackSpecified { get; set; }

        [DefaultValue("")]
        public string InstanceOfName { get; set; } = string.Empty;
        [XmlIgnore]
        public bool InstanceOfNameSpecified { get; set; }

        public ushort InstanceOfNumber { get; set; }
        [XmlIgnore]
        public bool InstanceOfNumberSpecified { get; set; }

        public InstanceOfType_TE InstanceOfType { get; set; }

        [DefaultValue("")]
        public string OfSystemLibElement { get; set; } = string.Empty;
        [XmlIgnore]
        public bool OfSystemLibElementSpecified { get; set; }

        [DefaultValue("")]
        public string OfSystemLibVersion { get; set; } = string.Empty;
        [XmlIgnore]
        public bool OfSystemLibVersionSpecified { get; set; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
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

                    case nameof(DownloadWithoutReinit):
                        DownloadWithoutReinit = reader.ReadElementContentAsBoolean();
                        DownloadWithoutReinitSpecified = true;
                        break;
                    case nameof(UDABlockProperties):
                        UDABlockProperties = reader.ReadElementContentAsString();
                        UDABlockPropertiesSpecified = true;
                        break;
                    case nameof(UDAEnableTagReadback):
                        UDAEnableTagReadback = reader.ReadElementContentAsBoolean();
                        UDAEnableTagReadbackSpecified = true;
                        break;
                    case nameof(InstanceOfName):
                        InstanceOfName = reader.ReadElementContentAsString();
                        InstanceOfNameSpecified = true;
                        break;
                    case nameof(InstanceOfNumber):
                        InstanceOfNumber = (ushort)reader.ReadElementContentAsInt();
                        InstanceOfNumberSpecified = true;
                        break;
                    case nameof(InstanceOfType):
                        Enum.TryParse<InstanceOfType_TE>(reader.ReadElementContentAsString(), out var instanceOfType);
                        InstanceOfType =instanceOfType;
                        break;
                    case nameof(OfSystemLibElement):
                        OfSystemLibElement = reader.ReadElementContentAsString();
                        OfSystemLibElementSpecified = true;
                        break;
                    case nameof(OfSystemLibVersion):
                        OfSystemLibVersion = reader.ReadElementContentAsString();
                        OfSystemLibVersionSpecified = true;
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
