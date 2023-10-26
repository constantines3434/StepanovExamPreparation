using System;
namespace YieldOperator
{
    class Program
    {
        static void Main(string[] argv)
        {
            foreach (int num in GetNums())
            {
                Console.WriteLine(num);
            }
        }

        public static IEnumerable<int> GetNums()
        {
            for (int i = 0;i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
