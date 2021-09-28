using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    //  This program demo. how to use async and await to perform async. operation.
    class TaskDemo6
    {
        static void Main()
        {

            TaskMethod1();
            TaskMethod2();
            Console.ReadLine();
        }

        public static async Task TaskMethod1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Method1-value is {i} {DateTime.Now.Millisecond}");
                    Task.Delay(2000).Wait();
                }
            });
        }
        public static async Task TaskMethod2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"Method2-value is {i} {DateTime.Now.Millisecond}");
                    Task.Delay(2000).Wait();
                }
            });
        }
    }
}
