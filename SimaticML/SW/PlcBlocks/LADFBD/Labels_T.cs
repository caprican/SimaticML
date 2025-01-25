using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Labels", IsNullable = false)]
    public class Labels_T : Object_G
    {
        [XmlElement("LabelDeclaration")]
        public CompileUnitCommon.LabelDeclaration_T[] LabelDeclaration { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var labels = new List<CompileUnitCommon.LabelDeclaration_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T();
                            label.ReadXml(reader);
                            labels.Add(label);
                            break;
                    }
                }
                if (labels.Count > 0) LabelDeclaration = labels.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Labels", IsNullable = false)]
    public class Labels_T_v2 : Labels_T
    {
        [XmlElement("LabelDeclaration")]
        public new CompileUnitCommon.LabelDeclaration_T_v2[] LabelDeclaration { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var labels = new List<CompileUnitCommon.LabelDeclaration_T_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T_v2();
                            label.ReadXml(reader);
                            labels.Add(label);
                            break;
                    }
                }
                if (labels.Count > 0) LabelDeclaration = labels.ToArray();

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
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Labels", IsNullable = false)]
    public class Labels_T_v4 : Labels_T_v2
    {
        [XmlElement("LabelDeclaration")]
        public new CompileUnitCommon.LabelDeclaration_T_v4[] LabelDeclaration { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var labels = new List<CompileUnitCommon.LabelDeclaration_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "LabelDeclaration":
                            var label = new CompileUnitCommon.LabelDeclaration_T_v4();
                            label.ReadXml(reader);
                            labels.Add(label);
                            break;
                    }
                }
                if (labels.Count > 0) LabelDeclaration = labels.ToArray();

            }
            reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
