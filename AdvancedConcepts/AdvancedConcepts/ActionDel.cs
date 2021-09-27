using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    //  This program demo. how to use Action Delegate.
    //  Action delegate is an in-built generic type delegate.you need not to create custom delegate.
    //  it can contain minimum 1 param. and maximum 16 param.
    //  The Action delegate generally used for functions which do not return value.
    class ActionDel
    {
        public static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine($"The result is:{firstNum + secondNum}");
        }

        static void Main()
        {
            Action<int, int> action = Add;
            action(30, 50);
            Console.ReadLine();
        }
    }
}
