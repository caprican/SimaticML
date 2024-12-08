using System;
using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.ProfileDataCam
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    [XmlRoot(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1", IsNullable = false)]
    public class ProfileData
    {
        public ProfileDataGeneralConfiguration GeneralConfiguration { get; set; }

        [XmlArrayItem("InverseSine", typeof(ProfileDataInverseSine), IsNullable = false)]
        [XmlArrayItem("Line", typeof(ProfileDataLine), IsNullable = false)]
        [XmlArrayItem("Point", typeof(PointElementType), IsNullable = false)]
        [XmlArrayItem("PointGroup", typeof(ProfileDataPointGroup), IsNullable = false)]
        [XmlArrayItem("Polynomial", typeof(ProfileDataPolynomial), IsNullable = false)]
        [XmlArrayItem("Sine", typeof(ProfileDataSine), IsNullable = false)]
        [XmlArrayItem("VDITransition", typeof(ProfileDataVDITransition), IsNullable = false)]
        public object[] Elements { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataGeneralConfiguration
    {
        public ProfileDataGeneralConfiguration()
        {
            StandardContinuity = ProfileContinuity.Acceleration;
            StandardOptimizationGoal = ProfileOptimizationGoal.None;
            InterpolationMode = ProfileInterpolationMode.CubicSpline;
            BoundaryConditions = BoundaryConditions.NoConstraint;
        }

        /// <summary>
        /// Requires start < end validity - default is [0;360]
        /// </summary>
        public DefinitionRange DesignLeadingRange { get; set; }

        /// <summary>
        /// Requires start < end validity - default is [-1;1]
        /// </summary>
        public DefinitionRange DesignFollowingRange { get; set; }

        [XmlAttribute]
        [DefaultValue(ProfileContinuity.Acceleration)]
        public ProfileContinuity StandardContinuity { get; set; }

        [XmlAttribute]
        [DefaultValue(ProfileOptimizationGoal.None)]
        public ProfileOptimizationGoal StandardOptimizationGoal { get; set; }

        [XmlAttribute]
        [DefaultValue(ProfileInterpolationMode.CubicSpline)]
        public ProfileInterpolationMode InterpolationMode { get; set; }

        [XmlAttribute]
        [DefaultValue(BoundaryConditions.NoConstraint)]
        public BoundaryConditions BoundaryConditions { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataInverseSine : SegmentBase
    {
        public ProfileDataInverseSine()
        {
            InterpolationPointCount = "32";
            MaxFollowingValueTolerance = (float)0.01F;
            MathStartX = (float)-0.95F;
            MathEndX = (float)0.95F;
            Inversed = false;
        }

        [XmlAttribute(DataType = "integer")]
        [DefaultValue("32")]
        public string InterpolationPointCount { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0.01")]
        public float MaxFollowingValueTolerance { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "-0.95")]
        public float MathStartX { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0.95")]
        public float MathEndX { get; set; }

        [XmlAttribute]
        public float Minimum { get; set; }
        [XmlIgnore]
        public bool MinimumSpecified { get; set; }

        [XmlAttribute]
        public float Maximum { get; set; }
        [XmlIgnore]
        public bool MaximumSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Inversed { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataLine : SegmentBase
    {
        //Two out of three are required here

        [XmlAttribute]
        public float StartY { get; set; }
        [XmlIgnore]
        public bool StartYSpecified { get; set; }

        [XmlAttribute]
        public float EndY { get; set; }
        [XmlIgnore]
        public bool EndYSpecified { get; set; }

        [XmlAttribute]
        public float Gradient { get; set; }
        [XmlIgnore]
        public bool GradientSpecified { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataPointGroup : SegmentBase
    {
        public ProfileDataPointGroup()
        {
            ApproximationDataPoints = "32";
            ApproximationTolerance = (float)0.01F;
            LeadingValueMode = ValueMode.Absolute;
            FollowingValueMode = ValueMode.Absolute;
            ApproximationMode = PointGroupApproximationMode.SegmentApproximation;
            InterpolationMode = PointGroupInterpolationMode.CubicSpline;
        }

        // Allow points to be sub-elements of the group
        [XmlElement("Point")]
        public PointElementType[] Point { get; set; }

        [XmlAttribute(DataType = "integer")]
        [DefaultValue("32")]
        public string ApproximationDataPoints { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0.01")]
        public float ApproximationTolerance { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LeadingValueMode { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode FollowingValueMode { get; set; }

        [XmlAttribute]
        [DefaultValue(PointGroupApproximationMode.SegmentApproximation)]
        public PointGroupApproximationMode ApproximationMode { get; set; }

        [XmlAttribute]
        [DefaultValue(PointGroupInterpolationMode.CubicSpline)]
        public PointGroupInterpolationMode InterpolationMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataPolynomial : SegmentBase
    {
        // With or without trigonometric portion ? If node doesn't exist, we simply use a non-trig. polynomial -->
        // 2 out of 4 : startPhase, endPhase, frequency, periodLength
        public TrigonometricValues TrigonometricValues { get; set; }

        //For V3, one of these nodes is required.

        [XmlElement("Coefficients", typeof(ProfileDataPolynomialCoefficients))]
        [XmlElement("Constraints", typeof(ProfileDataPolynomialConstraints))]
        public object Item { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataPolynomialCoefficients
    {
        public ProfileDataPolynomialCoefficients()
        {
            C0 = (float)0F;
            C1 = (float)0F;
            C2 = (float)0F;
            C3 = (float)0F;
            C4 = (float)0F;
            C5 = (float)0F;
            C6 = (float)0F;
        }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C0 { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C1 { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C2 { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C3 { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C4 { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C5 { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float C6 { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataPolynomialConstraints
    {
        public ProfileDataPolynomialConstraints()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float LeftValue { get; set; }
        [XmlIgnore]
        public bool LeftValueSpecified { get; set; }

        [XmlAttribute]
        public float RightValue { get; set; }
        [XmlIgnore]
        public bool RightValueSpecified { get; set; }

        [XmlAttribute]
        public float LeftVelocity { get; set; }
        [XmlIgnore]
        public bool LeftVelocitySpecified { get; set; }

        [XmlAttribute]
        public float RightVelocity { get; set; }
        [XmlIgnore]
        public bool RightVelocitySpecified { get; set; }

        [XmlAttribute]
        public float LeftAcceleration { get; set; }
        [XmlIgnore]
        public bool LeftAccelerationSpecified { get; set; }

        [XmlAttribute]
        public float RightAcceleration { get; set; }
        [XmlIgnore]
        public bool RightAccelerationSpecified { get; set; }

        // For V3, only one of these three parameters is allowed and lambda is always assumed to be absolute there.
        [XmlAttribute]
        public float LeftJerk { get; set; }
        [XmlIgnore]
        public bool LeftJerkSpecified { get; set; }

        [XmlAttribute]
        public float RightJerk { get; set; }
        [XmlIgnore]
        public bool RightJerkSpecified { get; set; }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransition : SegmentBase
    {
        public ProfileDataVDITransition()
        {
            LeftContinuity = ElementContinuity.AsProfile;
            RightContinuity = ElementContinuity.AsProfile;
            OptimizationGoal = ElementOptimizationGoal.AsProfile;
        }

        // The VDI-rules we know so far
        // If a VDI-rule occurs, the transition is handled as a VDI transition
        // For V3, lambda is always expected to be absolute -> mode is ignored there.

        [XmlElement("DoubleHarmonicTransition", typeof(object))]
        [XmlElement("HarmonicCombination", typeof(ProfileDataVDITransitionHarmonicCombination))]
        [XmlElement("InclinedSine", typeof(ProfileDataVDITransitionInclinedSine))]
        [XmlElement("Linear", typeof(object))]
        [XmlElement("ModifiedAccelerationTrapezoid", typeof(ProfileDataVDITransitionModifiedAccelerationTrapezoid))]
        [XmlElement("ModifiedSine", typeof(ProfileDataVDITransitionModifiedSine))]
        [XmlElement("Polynomial", typeof(ProfileDataVDITransitionPolynomial))]
        [XmlElement("QuadraticParabola", typeof(ProfileDataVDITransitionQuadraticParabola))]
        [XmlElement("Sine", typeof(ProfileDataVDITransitionSine))]
        [XmlElement("SineLineCombination", typeof(ProfileDataVDITransitionSineLineCombination))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }

        [XmlIgnore]
        public ItemChoiceType ItemElementName { get; set; }

        [XmlAttribute]
        [DefaultValue(ElementContinuity.AsProfile)]
        public ElementContinuity LeftContinuity { get; set; }

        [XmlAttribute]
        [DefaultValue(ElementContinuity.AsProfile)]
        public ElementContinuity RightContinuity { get; set; }

        [XmlAttribute]
        [DefaultValue(ElementOptimizationGoal.AsProfile)]
        public ElementOptimizationGoal OptimizationGoal { get; set; }
    }

    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        DoubleHarmonicTransition,
        HarmonicCombination,
        InclinedSine,
        Linear,
        ModifiedAccelerationTrapezoid,
        ModifiedSine,
        Polynomial,
        QuadraticParabola,
        Sine,
        SineLineCombination
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataSine : SegmentBase
    {
        public ProfileDataSine()
        {
            Amplitude = (float)1F;
            StartPhase = (float)0F;
            EndPhase = (float)6.283185F;
            Frequency = (float)1F;
            PeriodLength = (float)1F;
            Inclination = (float)0F;
            StartOffset = (float)0F;
            EndOffset = (float)0F;
        }

        [XmlAttribute]
        [DefaultValue(typeof(float), "1")]
        public float Amplitude { get; set; }

        // two of four are required and at least StartPhase or EndPhase is required

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float StartPhase { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "6.283185")]
        public float EndPhase { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "1")]
        public float Frequency { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "1")]
        public float PeriodLength { get; set; }

        // Two out of three are required here

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float Inclination { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float StartOffset { get; set; }

        [XmlAttribute]
        [DefaultValue(typeof(float), "0")]
        public float EndOffset { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionHarmonicCombination
    {
        public ProfileDataVDITransitionHarmonicCombination()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionInclinedSine
    {
        public ProfileDataVDITransitionInclinedSine()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionModifiedAccelerationTrapezoid
    {
        public ProfileDataVDITransitionModifiedAccelerationTrapezoid()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionModifiedSine
    {
        public ProfileDataVDITransitionModifiedSine()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        public float Ca { get; set; }
        [XmlIgnore]
        public bool CaSpecified { get; set; }

        [XmlAttribute]
        public float CaStar { get; set; }
        [XmlIgnore]
        public bool CaStarSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionPolynomial
    {
        public ProfileDataVDITransitionPolynomial()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionQuadraticParabola
    {
        public ProfileDataVDITransitionQuadraticParabola()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionSine
    {
        public ProfileDataVDITransitionSine()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Cam/v1")]
    public class ProfileDataVDITransitionSineLineCombination
    {
        public ProfileDataVDITransitionSineLineCombination()
        {
            LambdaMode = ValueMode.Absolute;
        }

        [XmlAttribute]
        public float Lambda { get; set; }
        [XmlIgnore]
        public bool LambdaSpecified { get; set; }

        [XmlAttribute]
        public float C { get; set; }
        [XmlIgnore]
        public bool CSpecified { get; set; }

        [XmlAttribute]
        [DefaultValue(ValueMode.Absolute)]
        public ValueMode LambdaMode { get; set; }
    }
}
