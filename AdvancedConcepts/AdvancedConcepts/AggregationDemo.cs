using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    class AggregationDemo
    {

        //  This program demo. how to create aggregate relationship between objects.
        //  1.Dependency: There is no dependencies between objects.
        //  2.Relation:   There is weak relationship between objects.
        //  3.Use Case:   object can use another objects.
        
      
            static void Main()
            {
                Address address1 = new Address("23/5", "M.G.Road", "Pune");
                Person person1 = new Person("Satish Dere", address1);
                Console.WriteLine($"{person1.Name} residing at House No:{person1.ResidentialAddress.HouseNo},Area={person1.ResidentialAddress.Area},City={person1.ResidentialAddress.City}");
                Console.ReadLine();
            }
        }
        class Person
        {
            public string Name { get; set; }

            public Address ResidentialAddress { get; set; }

            public Person(string name, Address resdentialAddress)
            {
                this.Name = name;
                this.ResidentialAddress = resdentialAddress;
            }

        }
        class Address
        {
            public string HouseNo { get; set; }

            public string Area { get; set; }
            public string City { get; set; }

            public Address(string houseNo, string area, string city)
            {
                this.HouseNo = houseNo;
                this.Area = area;
                this.City = city;
            }
        }
    }

