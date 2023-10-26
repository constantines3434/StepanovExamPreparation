using System;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] argv)
        {
            Person Consta = new Person(1, "Consta");
            Person? Consta1 = new Person(2, "Consta2");

            //запись в .json
            using (FileStream fs = new FileStream("Consta.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, Consta);
                Console.WriteLine("Объект был сериализован");
            }
            //вывод .json
            using (FileStream fs = new FileStream("Consta.json", FileMode.OpenOrCreate))
            {
                Consta1 = JsonSerializer.Deserialize<Person>(fs);
            }
            
            Console.WriteLine($"JSON:\nName: {Consta1?.Name}  Id: {Consta1?.Id}");


            //xml 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (FileStream fs = new FileStream("Consta.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, Consta);
            }

            //десереализация
            using (FileStream fs = new FileStream("Consta.xml", FileMode.OpenOrCreate))
            {
                Consta1 = xmlSerializer.Deserialize(fs) as Person; 
            }
            Console.WriteLine($"XML:\nName: {Consta1?.Name}  Id: {Consta1?.Id}");
        }
    }
}