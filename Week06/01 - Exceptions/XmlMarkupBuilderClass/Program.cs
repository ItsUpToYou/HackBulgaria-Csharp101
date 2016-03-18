using System;
using XmlMarkupBuilderLib;
namespace XmlMarkupBuilderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Make an easy to use XmlMarkupBuilder class, which creates a valid xml
            We won't worry about namespaces here. By valid, I mean having the <?xml version="1.0" encoding="UTF-8"?> declaration, and having only tags, attributes, and text between a tag opening and tag closing.

        For instance:
        <elements>
             <element attr="attributeValue">attr</element>
        </elements>
            */

            XMLMarkupBuilder xml = new XMLMarkupBuilder();
            xml.openTag("Elements");
            xml.AddAttr("attr", "attrvalue");
            xml.addText("Running");
            xml.openTag("Element").AddAttr("attribute", "=value").addText("Text-Test");
            xml.Finalize();
            Console.WriteLine(xml.GetResult());
        }
    }
}
