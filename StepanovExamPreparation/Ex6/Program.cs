using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Hello, World!");

            foreach(int num in GetNums())
            {
                Console.WriteLine(num);
            }
            
        }
        public static IEnumerable<int> GetNums()
        {
            for(int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
            
    }
}
