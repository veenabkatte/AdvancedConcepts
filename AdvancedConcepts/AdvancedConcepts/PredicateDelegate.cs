using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    //  This program demo. how to declare predicate delegate.
    // A predicate delegate is an in-built generic type delegate.
    // It works with those methods which contain some set of criteria and determine whether the passed parameter fulfill the given criteria or not.
    //  It can accept only single parameter.
    class PredicateDelegate
    {
        public static bool Function1(string myStr)
        {
            if (myStr.Length < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Predicate<string> predicate = Function1;
            Console.WriteLine(predicate("Hello World"));
            Console.ReadLine();
        }
    }
}
