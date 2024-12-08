using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.TechnologicalObjects.AdditionalDataAxis
{
    /// <summary>
    /// Describes a connection of a TO interface.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/Openness/SW/Motion/Axis/v1")]
    public class Connection_T
    {
        public Connection_T()
        {
            ConnectOption = ConnectOption_TE.Default;
        }

        /// <summary>
        /// Specifies the Interface of the TO that is connected.
        /// </summary>
        [XmlAttribute]
        public Interface_TE Interface { get; set; }

        /// <summary>
        /// Input bit address.
        /// </summary>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string InputAddress { get; set; }

        /// <summary>
        /// Output bit address.
        /// </summary>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string OutputAddress { get; set; }

        /// <summary>
        /// Connect option used when the connection has been created.
        /// </summary>
        [XmlAttribute]
        [DefaultValue(ConnectOption_TE.Default)]
        public ConnectOption_TE ConnectOption { get; set; }

        /// <summary>
        /// Index of sensor in actor telegram if connected to same telegram.
        /// </summary>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string SensorIndexInActorTelegram { get; set; }

        /// <summary>
        /// Path to a DB member.
        /// </summary>
        [XmlAttribute]
        public string PathToDBMember { get; set; }

        /// <summary>
        /// Name of a connected tag for analog connection.
        /// </summary>
        [XmlAttribute]
        public string OutputTag { get; set; }
    }
}
