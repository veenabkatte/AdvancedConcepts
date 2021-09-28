using System;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    class TaskDemo1
    {
        static void Main()
        {
            Task task1 = new Task(Message);
            task1.Start();
            Task task2 = new Task(Message1);
            task2.Start();
            Console.ReadLine();
        }

        public static void Message()
        {
            Console.WriteLine($"Starting a Task1....{Task.CurrentId}");
        }

        public static void Message1()
        {
            Console.WriteLine($"Starting a Task2....{Task.CurrentId}");
        }
    }
}
