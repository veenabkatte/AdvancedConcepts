using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    //  This program demo. how to create compisition relationship between objects.
    class CompositionDemo
    {
        static void Main()
        {
            University university1 = new University();
            Department department1 = new Department(university1, 100, "HR");
            university1.AddDepartment(department1.DeptCode, department1.DeptName);
            university1.Dispose();
            Console.ReadLine();
        }
    }
    class University : IDisposable
    {
        public List<Department> Departments { get; set; }

        public void AddDepartment(int deptCode, string deptName)
        {
            Departments.Add(new Department(this, deptCode, deptName));
        }

        public void Dispose()
        {
            foreach (var dept in Departments)
            {
                dept.Dispose();
            }
            this.Dispose();
        }
    }

    class Department : IDisposable
    {
        public University University { get; set; }
        public int DeptCode { get; set; }

        public string DeptName { get; set; }

        public Department(University university, int deptCode, string deptName)
        {
            this.University = university;
            this.DeptCode = deptCode;
            this.DeptName = deptName;
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
