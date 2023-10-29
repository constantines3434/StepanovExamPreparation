using System;
using System.Text.Json;
using System.Xml.Serialization;
namespace SerializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(1, "Rouble", 1.488);
            Data data1 = new Data(2, "Euro", 6.66);

            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, data);
                serializer.Serialize(fs, data1);
            }
        }        
    }
}
