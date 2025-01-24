using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Steps", IsNullable = false)]
    public class Steps_T : Object_G
    {
        [XmlElement("Step")]
        public Step_T[] Step { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var steps = new List<Step_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Step":
                            var step = new Step_T();
                            step.ReadXml(reader);
                            steps.Add(step);
                            break;
                    }
                }
                if (steps.Count > 0) Step = steps.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Steps", IsNullable = false)]
    public class Steps_T_v2 : Steps_T
    {
        [XmlElement("Step")]
        public new Step_T_v2[] Step { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var steps = new List<Step_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Step":
                            var step = new Step_T_v2();
                            step.ReadXml(reader);
                            steps.Add(step);
                            break;
                    }
                }
                if (steps.Count > 0) Step = steps.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Steps", IsNullable = false)]
    public class Steps_T_v4 : Steps_T_v2
    {
        [XmlElement("Step")]
        public new Step_T_v4[] Step { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var steps = new List<Step_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Step":
                            var step = new Step_T_v4();
                            step.ReadXml(reader);
                            steps.Add(step);
                            break;
                    }
                }
                if (steps.Count > 0) Step = steps.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Steps", IsNullable = false)]
    public class Steps_T_v5 : Steps_T_v4
    {
        [XmlElement("Step")]
        public new Step_T_v5[] Step { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var steps = new List<Step_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Step":
                            var step = new Step_T_v5();
                            step.ReadXml(reader);
                            steps.Add(step);
                            break;
                    }
                }
                if (steps.Count > 0) Step = steps.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Steps", IsNullable = false)]
    public class Steps_T_v6 : Steps_T_v5
    {
        [XmlElement("Step")]
        public new Step_T_v6[] Step { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var steps = new List<Step_T_v6>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Step":
                            var step = new Step_T_v6();
                            step.ReadXml(reader);
                            steps.Add(step);
                            break;
                    }
                }
                if (steps.Count > 0) Step = steps.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
