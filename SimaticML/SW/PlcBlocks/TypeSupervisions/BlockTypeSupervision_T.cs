using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    public interface IBlockTypeSupervision
    {
        ISupervisedOperand SupervisedOperand { get; set; }

        bool SupervisedStatus { get; set; }

        IDelayOperand DelayOperand { get; set; }

        ICondition[] Conditions { get; set; }

        int CategoryNumber { get; set; }
        long? SubCategory1Number { get; set; }
        long? SubCategory2Number { get; set; }

        ISpecificField SpecificField { get; set; }

        int Number { get; set; }

        Type_TE Type { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class BlockTypeSupervision_T : Object_G, IBlockTypeSupervision
    {
        public ISupervisedOperand SupervisedOperand { get; set; }

        public bool SupervisedStatus { get; set; }

        public IDelayOperand DelayOperand { get; set; }

        [XmlArrayItem("Condition", IsNullable = false)]
        public ICondition[] Conditions { get; set; }

        public int CategoryNumber { get; set; }

        public long? SubCategory1Number { get; set; } = null;
        [XmlIgnore]
        public bool SubCategory1NumberSpecified { get; set; }

        public long? SubCategory2Number { get; set; } = null;
        [XmlIgnore]
        public bool SubCategory2NumberSpecified { get; set; }

        public ISpecificField SpecificField { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public Type_TE Type { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Type):
                        Enum.TryParse<Type_TE>(reader.ReadContentAsString(), out var type);
                        Type = type;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "SupervisedOperand":
                            var supervisedOperand = new SupervisedOperand_T();
                            supervisedOperand.ReadXml(reader);
                            SupervisedOperand = supervisedOperand;
                            break;
                        case "DelayOperand":
                            var delayOperand = new DelayOperand_T();
                            delayOperand.ReadXml(reader);
                            DelayOperand = delayOperand;
                            break;
                        case "SpecificField":
                            var specificField = new SpecificField_T();
                            specificField.ReadXml(reader);
                            SpecificField = specificField;
                            break;
                        case "SupervisedStatus":
                            SupervisedStatus = reader.ReadElementContentAsBoolean();
                            break;
                        case "Conditions":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var conditions = new List<ICondition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Condition":
                                            var condition = new Condition_T();
                                            condition.ReadXml(reader);
                                            conditions.Add(condition);
                                            break;
                                    }
                                }
                                if (conditions.Count > 0) Conditions = conditions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                        case "CategoryNumber":
                            CategoryNumber = reader.ReadElementContentAsInt();
                            break;
                        case "SubCategory1Number":
                            SubCategory1Number = reader.ReadElementContentAsLong();
                            SubCategory1NumberSpecified = true;
                            break;
                        case "SubCategory2Number":
                            SubCategory2Number = reader.ReadElementContentAsLong();
                            SubCategory2NumberSpecified = true;
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
    /// Schema : SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class BlockTypeSupervision_T_v2 : BlockTypeSupervision_T, IBlockTypeSupervision
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Number):
                        Number = reader.ReadContentAsInt();
                        break;
                    case nameof(Type):
                        Enum.TryParse<Type_TE>(reader.ReadContentAsString(), out var type);
                        Type = type;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "SupervisedOperand":
                            var supervisedOperand = new SupervisedOperand_T();
                            supervisedOperand.ReadXml(reader);
                            SupervisedOperand = supervisedOperand;
                            break;
                        case "DelayOperand":
                            var delayOperand = new DelayOperand_T();
                            delayOperand.ReadXml(reader);
                            DelayOperand = delayOperand;
                            break;
                        case "SpecificField":
                            var specificField = new SpecificField_T_v2();
                            specificField.ReadXml(reader);
                            SpecificField = specificField;
                            break;
                        case "SupervisedStatus":
                            SupervisedStatus = reader.ReadElementContentAsBoolean();
                            break;
                        case "Conditions":
                            reader.MoveToContent();
                            if (!reader.IsEmptyElement)
                            {
                                reader.Read();

                                var conditions = new List<ICondition>();
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch (reader.Name)
                                    {
                                        case "Condition":
                                            var condition = new Condition_T();
                                            condition.ReadXml(reader);
                                            conditions.Add(condition);
                                            break;
                                    }
                                }
                                if (conditions.Count > 0) Conditions = conditions.ToArray();
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();

                            break;
                        case "CategoryNumber":
                            CategoryNumber = reader.ReadElementContentAsInt();
                            break;
                        case "SubCategory1Number":
                            SubCategory1Number = reader.ReadElementContentAsLong();
                            SubCategory1NumberSpecified = true;
                            break;
                        case "SubCategory2Number":
                            SubCategory2Number = reader.ReadElementContentAsLong();
                            SubCategory2NumberSpecified = true;
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
