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
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T : Object_G
    {
        public PermanentOperations_T PreOperations { get; set; }

        [XmlElement("Sequence")]
        public Sequence_T[] Sequences { get; set; }

        public PermanentOperations_T PostOperations { get; set; }

        public AlarmsSettings_T AlarmsSettings { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<Sequence_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case "PostOperations":
                            PostOperations = new PermanentOperations_T();
                            PostOperations.ReadXml(reader);
                            break;
                        case "PreOperations":
                            PreOperations = new PermanentOperations_T();
                            PreOperations.ReadXml(reader);
                            break;
                        case "AlarmsSettings":
                            AlarmsSettings = new AlarmsSettings_T();
                            AlarmsSettings.ReadXml(reader);
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();

                reader.ReadEndElement();
            }
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
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v2 : Graph_T
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v2[] Sequences { get; set; }

        public new AlarmsSettings_T_v2 AlarmsSettings { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<Sequence_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v2();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case "PostOperations":
                            PostOperations = new PermanentOperations_T();
                            PostOperations.ReadXml(reader);
                            break;
                        case "PreOperations":
                            PreOperations = new PermanentOperations_T();
                            PreOperations.ReadXml(reader);
                            break;
                        case "AlarmsSettings":
                            AlarmsSettings = new AlarmsSettings_T_v2();
                            AlarmsSettings.ReadXml(reader);
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();

                reader.ReadEndElement();
            }
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
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v4 : Graph_T_v2
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v4[] Sequences { get; set; }

        public new AlarmsSettings_T_v4 AlarmsSettings { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<Sequence_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v4();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case "PostOperations":
                            PostOperations = new PermanentOperations_T();
                            PostOperations.ReadXml(reader);
                            break;
                        case "PreOperations":
                            PreOperations = new PermanentOperations_T();
                            PreOperations.ReadXml(reader);
                            break;
                        case "AlarmsSettings":
                            AlarmsSettings = new AlarmsSettings_T_v4();
                            AlarmsSettings.ReadXml(reader);
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();

                reader.ReadEndElement();
            }
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
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v5 : Graph_T_v4
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v5[] Sequences { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<Sequence_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v5();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case "PostOperations":
                            PostOperations = new PermanentOperations_T();
                            PostOperations.ReadXml(reader);
                            break;
                        case "PreOperations":
                            PreOperations = new PermanentOperations_T();
                            PreOperations.ReadXml(reader);
                            break;
                        case "AlarmsSettings":
                            AlarmsSettings = new AlarmsSettings_T_v4();
                            AlarmsSettings.ReadXml(reader);
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();

                reader.ReadEndElement();
            }
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
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v6 : Graph_T_v5
    {
        [XmlElement("Sequence")]
        public new Sequence_T_v6[] Sequences { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<Sequence_T_v6>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v6();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case "PostOperations":
                            PostOperations = new PermanentOperations_T();
                            PostOperations.ReadXml(reader);
                            break;
                        case "PreOperations":
                            PreOperations = new PermanentOperations_T();
                            PreOperations.ReadXml(reader);
                            break;
                        case "AlarmsSettings":
                            AlarmsSettings = new AlarmsSettings_T_v4();
                            AlarmsSettings.ReadXml(reader);
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
