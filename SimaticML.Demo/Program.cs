// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using System.Xml;

Console.WriteLine("Hello, World!");

//var fileName = @"C:\Users\capri\OneDrive\Documents\Automation\TIA069\UserFiles\Export\N100_Defauts.xml";
//var fileName = @"C:\Users\capri\OneDrive\Documents\Automation\TIA069\UserFiles\Export\LSKF_Motor.xml";
//var fileName = @"C:\Users\capri\OneDrive\Documents\Automation\TIA069\UserFiles\Export\TMA_R1_AlarmesAvertissements.xml";
var fileName = @"C:\Users\capri\OneDrive\Documents\Automation\TIA069\UserFiles\Export\N100.xml";

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
        case SimaticML.SW.Blocks.GlobalDB globalDB:
            //var item = globalDB.AttributeList.Interface.Sections[0];//.Member[0];

            break;
    }
}


void OnUnknownElement(object? sender, XmlElementEventArgs e)
{
}

void OnUnknownAttribute(object? sender, XmlAttributeEventArgs e)
{
}