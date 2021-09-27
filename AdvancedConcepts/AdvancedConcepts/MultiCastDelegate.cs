using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    class MultiCastDelegate
    {
        //  1.TO declare delegate.
        public delegate void RectDel(double height, double width);

        public void Area(double height, double width)
        {
            Console.WriteLine($"The area is:{height * width}");
        }
        public void Perimeter(double height, double width)
        {
            Console.WriteLine($"The perimeter is:{2 * (height + width)}");
        }
        static void Main()
        {
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate();
            //  2.To init. delegate
            RectDel rectDel = new RectDel(multiCastDelegate.Area);
            rectDel += multiCastDelegate.Perimeter;
            //  3.To invoke delegate
            rectDel(10, 20);

            rectDel -= multiCastDelegate.Area;
            rectDel(10, 5);
            Console.ReadLine();
        }
    }
}
