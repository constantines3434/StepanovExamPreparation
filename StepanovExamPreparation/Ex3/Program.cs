using System;
using System.Diagnostics;

namespace Ex4
{
    class Program
    {
        static void Main(string[] argv)
        {
            int a = 5;
            int b = 10;
            int c = a + b;

            StackTrace stackTrace = new StackTrace();
            int frameCount = stackTrace.FrameCount;

            for (int i = 0; i < frameCount; i++)
            {
                StackFrame frame = stackTrace.GetFrame(i);
                Console.WriteLine($"Кадр стека {i + 1}");
                Console.WriteLine($"Метод {frame.GetMethod()}");
                Console.WriteLine($"Файл {frame.GetFileName()}");
                Console.WriteLine($"Строка: {frame.GetFileLineNumber()}");
            }
        }
    }
}
