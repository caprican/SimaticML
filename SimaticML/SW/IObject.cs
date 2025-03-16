using System.Xml.Serialization;

namespace SimaticML.SW
{
    public interface IObject : IXmlSerializable
    {

    }

    public abstract class Object_G : IObject
    {
        public abstract void ReadXml(System.Xml.XmlReader reader);
        public abstract void WriteXml(System.Xml.XmlWriter writer);
        public System.Xml.Schema.XmlSchema GetSchema() => null;
    }
}
