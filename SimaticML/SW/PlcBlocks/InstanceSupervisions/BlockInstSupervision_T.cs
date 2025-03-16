using System;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    public interface IBlockInstSupervision
    {
        int Number { get; set; }
        IStateStruct StateStruct { get; set; }
        int BlockTypeSupervisionNumber { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.InstanceSupervisions => SW.Common</item>
    /// <item>SW.PlcBlocks.InstanceSupervisions_v2 => SW.Common_v2</item>
    /// <item>SW.PlcBlocks.InstanceSupervisions_v3 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class BlockInstSupervision_T : Object_G, IBlockInstSupervision
    {
        public int Number { get; set; }

        public IStateStruct StateStruct { get; set; }

        public int BlockTypeSupervisionNumber { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
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
                        case nameof(Number) :
                            Number = reader.ReadElementContentAsInt();
                            break;
                        case nameof(StateStruct) :
                            var stateStruct = new StateStruct_T();
                            stateStruct.ReadXml(reader);
                            StateStruct = stateStruct;
                            break;
                        case nameof(BlockTypeSupervisionNumber) :
                            BlockTypeSupervisionNumber = reader.ReadElementContentAsInt();
                            break;

                        default:
                            reader.Skip();
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
