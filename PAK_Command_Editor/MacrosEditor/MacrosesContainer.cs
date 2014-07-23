using PAK_Command_Editor.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PAK_Command_Editor.MacrosEditor
{
    public class MacrosesContainer
    {
        public Signal AssociatedSignal { get; set; }
        public List<MacrosCommandWithParams> Commands { get; set; }

        public MacrosesContainer()
        {
            this.Commands = new List<MacrosCommandWithParams>();
        }

        public void SaveToFile(String fileName)
        {
            XDocument doc = new XDocument();
            using (var writer = doc.CreateWriter())
            {
                // write xml into the writer
                XmlAttributeOverrides xmlOver = new XmlAttributeOverrides();
                XmlAttributes xmlAttr = new XmlAttributes();
                xmlAttr.XmlIgnore = true;
                xmlOver.Add(typeof(Signal), "Device", xmlAttr);
                var serializer = new XmlSerializer(this.GetType(), xmlOver);
                serializer.Serialize(writer, this);
            }
            doc.Save(fileName);
        }

        public static MacrosesContainer GetFromFile(String fileName)
        {
            MacrosesContainer macrosesContainer = null;
            
            using (StreamReader reader = new StreamReader(fileName))
            {
                XmlAttributeOverrides xmlOver = new XmlAttributeOverrides();
                XmlAttributes xmlAttr = new XmlAttributes();
                xmlAttr.XmlIgnore = true;
                xmlOver.Add(typeof(Signal), "Device", xmlAttr);
                XmlSerializer serializer = new XmlSerializer(typeof(MacrosesContainer), xmlOver);
                macrosesContainer = (MacrosesContainer)serializer.Deserialize(reader);
            }

            return macrosesContainer;
        }
    }
}
