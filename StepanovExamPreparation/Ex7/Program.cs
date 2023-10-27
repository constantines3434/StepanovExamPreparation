using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введи набор символов");
        string input = "was ist\ndas"; // Ваш ввод
        string path = "data.txt";

        // Запись
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.Write(input);
        }

        // Чтение из файла
        using (StreamReader sr = new StreamReader(path))
        {
            string line = sr.ReadToEnd();
            Console.WriteLine("Прочитано из файла:");
            Console.WriteLine(line);
        }

        Console.ReadLine();
    }
}
