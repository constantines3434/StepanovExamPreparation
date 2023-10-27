using System;
using System.Text.Json;
namespace SerializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(1, "Rouble", 1.488);
            Data data1 = new Data(2, "Euro", 6.66);
            using (FileStream fs = new FileStream("data.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, data);
                JsonSerializer.Serialize(fs, data1);
            }
        }        
    }
}
