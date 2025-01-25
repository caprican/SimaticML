using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class BlockTypeSupervision : Object_G
    {
        public SupervisedOperand SupervisedOperand { get; set; }

        public bool SupervisedStatus { get; set; }

        public DelayOperand DelayOperand { get; set; }

        [XmlArrayItem("Condition", IsNullable = false)]
        public Condition[] Conditions { get; set; }

        public int CategoryNumber { get; set; }

        public long? SubCategory1Number { get; set; } = null;
        [XmlIgnore]
        public bool SubCategory1NumberSpecified { get; set; }

        public long? SubCategory2Number { get; set; } = null;
        [XmlIgnore]
        public bool SubCategory2NumberSpecified { get; set; }

        public SpecificField SpecificField { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public Type Type { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("Number"), out var number);
            Number = number;

            _ = Enum.TryParse<Type>(reader.GetAttribute("Type"), out var type);
            Type = type;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var conditions = new List<Condition>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "SupervisedOperand":
                            SupervisedOperand = new SupervisedOperand();
                            SupervisedOperand.ReadXml(reader);
                            break;
                        case "DelayOperand":
                            DelayOperand = new DelayOperand();
                            DelayOperand.ReadXml(reader);
                            break;
                        case "SpecificField":
                            SpecificField = new SpecificField();
                            SpecificField.ReadXml(reader);
                            break;
                        case "SupervisedStatus":

                            break;
                        case "Conditions":
                            var condition = new Condition();
                            condition.ReadXml(reader);
                            conditions.Add(condition);
                            break;
                        case "CategoryNumber":

                            break;
                    }
                }
                if(conditions.Count > 0) Conditions = conditions.ToArray();
            }
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
    public class BlockTypeSupervision_v2 : BlockTypeSupervision
    {
        public new SpecificField_v2 SpecificField { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = int.TryParse(reader.GetAttribute("Number"), out var number);
            Number = number;

            _ = Enum.TryParse<Type>(reader.GetAttribute("Type"), out var type);
            Type = type;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var conditions = new List<Condition>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "SupervisedOperand":
                            SupervisedOperand = new SupervisedOperand();
                            SupervisedOperand.ReadXml(reader);
                            break;
                        case "DelayOperand":
                            DelayOperand = new DelayOperand();
                            DelayOperand.ReadXml(reader);
                            break;
                        case "SpecificField":
                            SpecificField = new SpecificField_v2();
                            SpecificField.ReadXml(reader);
                            break;
                        case "SupervisedStatus":

                            break;
                        case "Conditions":
                            var condition = new Condition();
                            condition.ReadXml(reader);
                            conditions.Add(condition);
                            break;
                        case "CategoryNumber":

                            break;
                    }
                }
                if (conditions.Count > 0) Conditions = conditions.ToArray();
            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
