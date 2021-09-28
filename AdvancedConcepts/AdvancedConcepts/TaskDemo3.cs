using System;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    //  This program demo. how to create and run task sequentially.
    class TaskDemo3
    {
        static void Main()
        {
            Task task1 = new Task(PrintNumbers);
            task1.Start();
            //task1.Wait();
            Task task2 = new Task(PrintNumbers1);
            task2.Start();
            Console.ReadLine();
        }
        public static void PrintNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Task1....{i}");
                Task.Delay(2000).Wait();
            }
        }
        public static void PrintNumbers1()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine($"Task2....{i}");
                Task.Delay(2000).Wait();
            }
        }
    }
}
