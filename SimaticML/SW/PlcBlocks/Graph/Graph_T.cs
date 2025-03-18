using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    public interface IGraph
    {
        IPermanentOperations PreOperations { get; set; }
        ISequence[] Sequences { get; set; }
        IPermanentOperations PostOperations { get; set; }
        IAlarmsSettings AlarmsSettings { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T : Object_G, IGraph
    {
        public IPermanentOperations PreOperations { get; set; }

        [XmlElement("Sequence")]
        public ISequence[] Sequences { get; set; }

        public IPermanentOperations PostOperations { get; set; }

        public IAlarmsSettings AlarmsSettings { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<ISequence>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case nameof(PostOperations) :
                            var postOperations = new PermanentOperations_T();
                            postOperations.ReadXml(reader);
                            PostOperations = postOperations;
                            break;
                        case nameof(PreOperations) :
                            var preOperations = new PermanentOperations_T();
                            preOperations.ReadXml(reader);
                            PreOperations = preOperations;
                            break;
                        case nameof(AlarmsSettings) :
                            var alarmsSettings = new AlarmsSettings_T();
                            alarmsSettings.ReadXml(reader);
                            AlarmsSettings = alarmsSettings;
                            break;
                        
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();
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
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v2 : Graph_T, IGraph
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<ISequence>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v2();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case nameof(PostOperations) :
                            var postOperations = new PermanentOperations_T();
                            postOperations.ReadXml(reader);
                            PostOperations = postOperations;
                            break;
                        case nameof(PreOperations) :
                            var preOperations = new PermanentOperations_T();
                            preOperations.ReadXml(reader);
                            PreOperations = preOperations;
                            break;
                        case nameof(AlarmsSettings) :
                            var alarmsSettings = new AlarmsSettings_T_v2();
                            alarmsSettings.ReadXml(reader);
                            AlarmsSettings = alarmsSettings;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();
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
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v4 : Graph_T_v2
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<ISequence>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v4();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case nameof(PostOperations) :
                            var postOperations = new PermanentOperations_T();
                            postOperations.ReadXml(reader);
                            PostOperations = postOperations;
                            break;
                        case nameof(PreOperations) :
                            var preOperations = new PermanentOperations_T();
                            preOperations.ReadXml(reader);
                            PreOperations = preOperations;
                            break;
                        case nameof(AlarmsSettings) :
                            var alarmsSettings = new AlarmsSettings_T_v4();
                            alarmsSettings.ReadXml(reader);
                            AlarmsSettings = alarmsSettings;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();
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
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v5 : Graph_T_v4
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<ISequence>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v5();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case nameof(PostOperations) :
                            var postOperations = new PermanentOperations_T();
                            postOperations.ReadXml(reader);
                            PostOperations = postOperations;
                            break;
                        case nameof(PreOperations) :
                            var preOperations = new PermanentOperations_T();
                            preOperations.ReadXml(reader);
                            PreOperations = preOperations;
                            break;
                        case nameof(AlarmsSettings) :
                            var alarmsSettings = new AlarmsSettings_T_v4();
                            alarmsSettings.ReadXml(reader);
                            AlarmsSettings = alarmsSettings;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();
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
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Graph", IsNullable = false)]
    public class Graph_T_v6 : Graph_T_v5
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sequences = new List<ISequence>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Sequence":
                            var sequence = new Sequence_T_v6();
                            sequence.ReadXml(reader);
                            sequences.Add(sequence);
                            break;
                        case nameof(PostOperations) :
                            var postOperations = new PermanentOperations_T();
                            postOperations.ReadXml(reader);
                            PostOperations = postOperations;
                            break;
                        case nameof(PreOperations) :
                            var preOperations = new PermanentOperations_T();
                            preOperations.ReadXml(reader);
                            PreOperations = preOperations;
                            break;
                        case nameof(AlarmsSettings) :
                            var alarmsSettings = new AlarmsSettings_T_v4();
                            alarmsSettings.ReadXml(reader);
                            AlarmsSettings = alarmsSettings;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (sequences.Count > 0) Sequences = sequences.ToArray();
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
