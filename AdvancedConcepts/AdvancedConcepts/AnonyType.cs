using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
   

        //  This program demo. how to declare anonymous types.

        //  Anonymous type does have any name
        class AnonyType
        {
            static void Main()
            {
                //  Anonymous types only contains read only properties.
                var student = new { RollNo = 100, Name = "Scott", Email = "scott@gmail.com" };
                //student.RollNo = 101; //Error
                Console.WriteLine($"RollNo={student.RollNo} Name={student.Name} Email={student.Email}");

                var students = new[]
                {
                new  {RollNo=100,Name="Scott",Email="scott@gmail.com"},
                new{RollNo=101,Name="Tiger",Email="tiger@gmail.com" },
                new {RollNo=102,Name="Smith",Email="smith@gmail.com" }
            };

                foreach (var std in students)
                {
                    Console.WriteLine($"RollNo={std.RollNo} Name={std.Name} Email={std.Email}");

                }
                Console.ReadLine();
            }
        }
    }

