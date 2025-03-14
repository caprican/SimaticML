﻿using System.Xml.Serialization;
using System.Xml;

var fileName = @"C:\.xml";

var settings = new XmlReaderSettings
{
    //ValidationType = ValidationType.Schema
};
//settings.Schemas.Add("", @"Schemas\Commons\SW.Common_v3.xsd");
//settings.Schemas.Add("http://www.siemens.com/automation/Openness/SW/Interface/v5", @"Schemas\InterfaceSections\SW.InterfaceSections_v5.xsd");


var serializer = new XmlSerializer(typeof(SimaticML.Document)/*, attrOverrides*/);
serializer.UnknownAttribute += OnUnknownAttribute;
serializer.UnknownElement += OnUnknownElement;

var reader = XmlReader.Create(fileName, settings);

if (serializer.Deserialize(reader) is SimaticML.Document document)
{
    switch (document[0])
    {
        case SimaticML.SW.Blocks.OB ob:
            break;
        case SimaticML.SW.Blocks.FC fc:
            break;
        case SimaticML.SW.Blocks.FB fb:
            break;
        case SimaticML.SW.Blocks.GlobalDB globalDB:
            //var item = globalDB.AttributeList.Interface.Sections[0];//.Member[0];
            break;
        case SimaticML.SW.Blocks.ArrayDB arrayDB:
            break;
        case SimaticML.SW.Blocks.InstanceDB instanceDB:
            break;

        case SimaticML.SW.Types.PlcStruct plcStruct:
            break;
    }
}


void OnUnknownElement(object? sender, XmlElementEventArgs e)
{
}

void OnUnknownAttribute(object? sender, XmlAttributeEventArgs e)
{
}