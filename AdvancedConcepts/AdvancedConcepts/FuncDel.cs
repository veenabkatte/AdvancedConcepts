using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    //  This program demo. how to declare Func Delegate.
    //  This is generic in-built delegate.
    //  It is like Action delegate but it returns a value
    //  Out param must be a last param in list.
    class FuncDel
    {
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static void Main()
        {
            Func<int, int, int> func = Add;
            Console.WriteLine(func(30, 40));
            Console.ReadLine();
        }
    }
}
