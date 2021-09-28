using System;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    //  This program demo. how to return a value from Task using Task<TResult>.
    class TaskDemo4
    {
        static void Main()
        {
            var tResult = Task<int>.Run(() => {
                return PrintSum();
            });
            Console.WriteLine($"Sum={tResult.Result}");

            var tResult1 = Task<string>.Run(() => {
                return "This is Task2";
            });

            Console.WriteLine($"{tResult1.Result}");
            Console.ReadLine();
        }

        public static int PrintSum()
        {
            int sum = 0;
            for (int i = 1; i <= 15; i++)
            {
                sum = sum + i;

            }
            Task.Delay(2000).Wait();
            return sum;
        }
    }
}
