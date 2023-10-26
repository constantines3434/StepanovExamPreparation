using System;
using System.Text.Json;

namespace Ex2
{
    //2)Напишите метод-расширения для десериализации generic – типа
    class Program
    {
        static void Main(string[] args)
        {
            Data<int> data = new Data<int>(1, "Rouble", 1.488);

            // Сериализация
            try
            {
                SerializeGeneric.SerializeToJSON("Data.json", data);
                Console.WriteLine("Serialized JSON: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка сериализации: " + ex.Message);
            }
            //// Десериализация
            //using (FileStream fs = new FileStream("Consta.json", FileMode.OpenOrCreate))
            //{

            //    Data<int> deserializedData = json.DeserializeFromJSON<Data<int>>();
            //    Console.WriteLine("Deserialized Id: " + deserializedData.id);
            //}
        }
    }
}