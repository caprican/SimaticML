using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.Graph => SW.PlcBlocks.LADFBD + SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common</item>
    /// <item>SW.PlcBlocks.Graph_v2 => SW.PlcBlocks.LADFBD_v2 + SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2 </item>
    /// <item>SW.PlcBlocks.Graph_v4 => SW.PlcBlocks.LADFBD_v3 + SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.Graph_v5 => SW.PlcBlocks.LADFBD_v4 + SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.Graph_v6 => SW.PlcBlocks.LADFBD_v5 + SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("NodeFrom", IsNullable = false)]
    public class Node_T : Object_G
    {
        [XmlElement("BranchRef", typeof(BranchRef_T))]
        [XmlElement("EndConnection", typeof(EndConnection_T))]
        [XmlElement("StepRef", typeof(StepRef_T))]
        [XmlElement("TransitionRef", typeof(TransitionRef_T))]
        public Object_G Item { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BranchRef":
                            Item = new BranchRef_T();
                            Item.ReadXml(reader);
                            break;
                        case "EndConnection":
                            Item = new EndConnection_T();
                            Item.ReadXml(reader);
                            break;
                        case "StepRef":
                            Item = new StepRef_T();
                            Item.ReadXml(reader);
                            break;
                        case "TransitionRef":
                            Item = new TransitionRef_T();
                            Item.ReadXml(reader);
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
