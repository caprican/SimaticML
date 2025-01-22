using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML.SW
{
    public abstract class Object_G : IXmlSerializable
    {
        public XmlSchema GetSchema() => null;

        public abstract void ReadXml(XmlReader reader);

        public abstract void WriteXml(XmlWriter writer);
    }
}
