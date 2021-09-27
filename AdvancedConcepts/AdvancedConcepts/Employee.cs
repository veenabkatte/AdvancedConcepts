using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    [Serializable]

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }

        [NonSerialized]
        private string empEmail;
        public string Email
        {
            get
            {
                return empEmail;
            }
            set
            {
                empEmail = value;
            }
        }

    }
}
