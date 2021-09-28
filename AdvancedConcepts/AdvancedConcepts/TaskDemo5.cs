using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    //  This program demo. how to return complex type using Task<tResult>.
    class TaskDemo5
    {
        static void Main()
        {
            var tResult = Task<Employee>.Run(() => {
                List<Employee> employees = new List<Employee>
                {
                    new Employee{EmpCode=100,EmpName="Scott",Email="scott@gmail.com" },
                    new Employee{EmpCode=101,EmpName="Tiger",Email="tiger@gmail.com"  }
                };
                return employees;
            });

            foreach (var employee in tResult.Result)
            {
                Console.WriteLine($"Code={employee.EmpCode}\tName={employee.EmpName}\tEmail={employee.Email}");
            }
            Console.ReadLine();
        }
    }
}
