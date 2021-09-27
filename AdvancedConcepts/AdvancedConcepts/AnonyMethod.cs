using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    //  This program demo. how to declare anonymous methods.
    //  Method without name.
    //  Anonymous method can be defined using the delegate keyword and can be assigned to a variable of del type.
    class AnonyMethod
    {
        public delegate void Print(int value);

        static void Main()
        {
            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            Print printDel = delegate (int value)
            {
                Console.WriteLine($"Anonymous method print value:{value}");
            };
            printDel(100);

            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a int
            // as an input parameter (x). The type of x is inferred by the compiler.

            Print printDel1 = (x) => Console.WriteLine($"Anonymous method print value:{x}");
            printDel1(200);

            // How to use Action Delegate to create Anonymous function
            Action<int> actionDel = delegate (int val)
            {
                Console.WriteLine($"Anonymous method print value:{val}");
            };
            actionDel(300);

            // lambda expression with Action Delegate
            Action<int> actionDel1 = i => Console.WriteLine($"Anonymous method print value:{i}");
            actionDel1(400);
            Console.ReadLine();
        }
    }
}
