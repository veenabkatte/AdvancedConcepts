using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    class AssociationDemo
    {
        //  This program demo. how to create Association Relationship.
        //  1.Dependency:There is no dependencies between objects.
        //  2.Relation: There is no relation between objects.
        //  3.Use Case: but object can use another objects.

        
            static void Main()
            {
                Car car1 = new Car { ModelNo = 123, Name = "Tata Indica" };
                Driver driver1 = new Driver { LicNo = 222, Name = "Satish" };
                driver1.Drive(car1);


                Car car2 = new Car { ModelNo = 233, Name = "Tata Safari" };
                Driver driver2 = new Driver { LicNo = 333, Name = "Sachin" };
                //driver2.Drive(car2);

                driver1.Drive(car2);
                Console.ReadLine();

            }
        }

        class Driver
        {
            public int LicNo { get; set; }
            public string Name { get; set; }

            public void Drive(Car car)
            {
                Console.WriteLine($"{this.Name} is driving {car.Name}");
            }
        }

        class Car
        {
            public int ModelNo { get; set; }
            public string Name { get; set; }
        }
    }

