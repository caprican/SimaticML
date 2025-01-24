using System;
using System.Collections.Generic;
using System.Threading;
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
    [XmlRoot("AlarmSupervisionCategory", IsNullable = false)]
    public class AlarmSupervisionCategory_T : Object_G
    {
        /// <summary>
        /// Enabler token
        /// </summary>
        public Common.Token_T Token { get; set; }

        [XmlAttribute]
        public ushort Id { get; set; }

        [XmlAttribute]
        public ushort DisplayClass { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = ushort.TryParse(reader.GetAttribute("Id"), out var id);
            Id = id;

            _ = ushort.TryParse(reader.GetAttribute("DisplayClass"), out var displayClass);
            DisplayClass = displayClass;


            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Token":
                            Token = new Common.Token_T();
                            Token.ReadXml(reader);
                            break;
                    }
                }

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
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("AlarmSupervisionCategory", IsNullable = false)]
    public class AlarmSupervisionCategory_T_v2 : AlarmSupervisionCategory_T
    {
        /// <summary>
        /// Enabler token
        /// </summary>
        public new Common.Token_T_v2 Token { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = ushort.TryParse(reader.GetAttribute("Id"), out var id);
            Id = id;

            _ = ushort.TryParse(reader.GetAttribute("DisplayClass"), out var displayClass);
            DisplayClass = displayClass;


            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Token":
                            Token = new Common.Token_T_v2();
                            Token.ReadXml(reader);
                            break;
                    }
                }

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
