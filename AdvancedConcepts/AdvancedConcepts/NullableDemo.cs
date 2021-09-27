using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    //  This program demo. how to convert int into Nullable type.
    class NullableDemo
    {
        static void Main()
        {

            Nullable<int> num = null;
            if (num.HasValue)
            {
                Console.WriteLine(num.Value);
            }
            else
            {
                Console.WriteLine("null");
            }

            int? i = null;
            i = i ?? 0;
            Console.WriteLine(i);

            EmpProfile empProfile = new EmpProfile { EmpCode = null, Name = "Scott" };
            Console.WriteLine($"Code={empProfile.EmpCode}\t Name={empProfile.Name}");
            Console.ReadLine();
        }
    }
    class EmpProfile
    {
        public int? EmpCode { get; set; }
        public string Name { get; set; }
    }
}
