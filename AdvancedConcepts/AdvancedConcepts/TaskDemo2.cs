using System;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    //  This program demo. how start Task immediately.
    class TaskDemo2
    {
        static void Main()
        {
            Task task1 = Task.Run(Message);
            Task task2 = Task.Run(Message1);
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
