using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML
{
    /// <summary>
    /// Attributes for all blocs
    /// </summary>
    [Serializable]
    public class AttributeList_G
    {
        [DefaultValue(true)]
        public bool AutoNumber { get; set; } = true;
        [XmlIgnore]
        public bool AutoNumberSpecified { get; set; }

        public DateTime? CodeModifiedDate { get; set; } = null;
        [XmlIgnore]
        public bool CodeModifiedDateSpecified { get; set; }

        public DateTime? CompileDate { get; set; } = null;
        [XmlIgnore]
        public bool CompileDateSpecified { get; set; }

        public DateTime? CreationDate { get; set; } = null;
        [XmlIgnore]
        public bool CreationDateSpecified { get; set; }

        [DefaultValue("")]
        public string HeaderAuthor { get; set; } = "";
        [XmlIgnore]
        public bool HeaderAuthorSpecified { get; set; }

        [DefaultValue("")]
        public string HeaderFamily { get; set; } = "";
        [XmlIgnore]
        public bool HeaderFamilySpecified { get; set; }

        [DefaultValue("")]
        public string HeaderName { get; set; } = "";
        [XmlIgnore]
        public bool HeaderNameSpecified { get; set; }

        [DefaultValue("0.1")]
        public string HeaderVersion { get; set; } = "0.1";
        [XmlIgnore]
        public bool HeaderVersionSpecified { get; set; }

        public SW.Interface_T Interface { get; set; } = null;
        [XmlIgnore]
        public bool InterfaceSpecified { get; set; }

        public DateTime? InterfaceModifiedDate { get; set; } = null;
        [XmlIgnore]
        public bool InterfaceModifiedDateSpecified { get; set; }

        public bool? IsConsistent { get; set; } = null;
        [XmlIgnore]
        public bool IsConsistentSpecified { get; set; }

        [DefaultValue(false)]
        public bool IsKnowHowProtected { get; set; } = false;
        [XmlIgnore]
        public bool IsKnowHowProtectedPrecified { get; set; }

        [DefaultValue(false)]
        public bool IsWriteProtected { get; set; } = false;
        [XmlIgnore]
        public bool IsWriteProtectedSpecified { get; set; }

        public MemoryLayout_TE? MemoryLayout { get; set; } = null;
        [XmlIgnore]
        public bool MemoryLayoutSpecified { get; set; }

        public DateTime? ModifiedDate { get; set; } = null;
        [XmlIgnore]
        public bool ModifiedDateSpecified { get; set; }

        public string Name { get; set; } = null;
        [XmlIgnore]
        public bool NameSpecified { get; set; }

        public int? Number { get; set; } = null;
        [XmlIgnore]
        public bool NumberSpecified { get; set; }

        public DateTime? ParameterModified { get; set; } = null;
        [XmlIgnore]
        public bool ParameterModifiedSpecified { get; set; }

        [DefaultValue(false)]
        public bool PLCSimAdvancedSupport { get; set; } = false;
        [XmlIgnore]
        public bool PLCSimAdvancedSupportSpecified { get; set; }

        public ProgrammingLanguage_TE? ProgrammingLanguage { get; set; } = null;
        [XmlIgnore]
        public bool ProgrammingLanguageSpecified { get; set; }

        public DateTime? StructureModified { get; set; } = null;
        [XmlIgnore]
        public bool StructureModifiedSpecified { get; set; }
    }
}
