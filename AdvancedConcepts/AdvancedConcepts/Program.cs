using System;

namespace AdvancedConcepts
{
    //A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods.
    class Program
    {
        
            //  1.To declare delegate
        public delegate void DelMath(int firstNum, int secondNum);

        //  Methods to work with Delegates
        public void Add(int firstNum, int secondNum)
        {
            Console.WriteLine($"The sum of two numbers is:{firstNum + secondNum}");
        }
        public void Sub(int firstNum, int secondNum)
        {
            Console.WriteLine($"The result is:{firstNum - secondNum}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //  2.To set function ref. to delegate or to init. Delegate

            DelMath delMath = new DelMath(program.Add);
            //  3.To invoke delegate
            delMath(100, 50);

            delMath = new DelMath(program.Sub);
            delMath(50, 20);

            Console.ReadLine();
        }
    }
    }

