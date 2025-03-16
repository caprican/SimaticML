namespace SimaticML.SW
{
    public abstract class Object_G
    {
        public abstract void ReadXml(System.Xml.XmlReader reader);
        public abstract void WriteXml(System.Xml.XmlWriter writer);
        public System.Xml.Schema.XmlSchema GetSchema() => null;
    }
}
