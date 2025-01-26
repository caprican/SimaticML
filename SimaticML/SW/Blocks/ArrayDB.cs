using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using SimaticML.SW.InterfaceSections;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class ArrayDB : Object_T, IXmlSerializable
    {
        [XmlElement("AttributeList", typeof(AttributesArrayDb))]
        public AttributesArrayDb Attributes { get; set; }

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
                }
            }

            reader.Read();
            reader.MoveToContent();
            if (reader.Name == "AttributeList")
            {
                var attributes = new AttributesArrayDb();
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

    public class AttributesArrayDb : AttributeList_G, IXmlSerializable
    {
        public string ArrayDataType { get; set; } = string.Empty;
        [XmlIgnore]
        public bool ArrayDataTypeSpecified { get; set; }

        public int? ArrayLimitUpperBound { get; set; } = null;
        [XmlIgnore]
        public bool ArrayLimitUpperBoundSpecified { get; set; }

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

                    case nameof(ArrayDataType):
                        ArrayDataType = reader.ReadElementContentAsString();
                        ArrayDataTypeSpecified = true;
                        break;
                    case nameof(ArrayLimitUpperBound):
                        ArrayLimitUpperBound = reader.ReadElementContentAsInt();
                        ArrayLimitUpperBoundSpecified = true;
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
