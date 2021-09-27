using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace AdvancedConcepts
{
    //  This program demo. how to Serialize and De-Serialize object of an Employee class.
    class SerAndDeser
    {
        static void Main()
        {
            SerAndDeser serAndDeser = new SerAndDeser();
            serAndDeser.DoSerialization();
            Console.WriteLine("Object is Serialized Successfully");
            serAndDeser.DoDeserialization();
            Console.ReadLine();
        }

        public void DoSerialization()
        {
            try
            {
                Employee employee = new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
                FileInfo fileInfo = new FileInfo("employee.dat");
                using (FileStream fileStream = fileInfo.Open(FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, employee);
                    fileStream.Close();
                }

            }
            catch (SerializationException ex) { }
        }

        public void DoDeserialization()
        {
            try
            {
                Employee employee = new Employee();
                FileInfo fileInfo = new FileInfo("employee.dat");
                using (FileStream fileStream = fileInfo.Open(FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    employee = (Employee)binaryFormatter.Deserialize(fileStream);
                    Console.WriteLine($"Code={employee.EmpCode}\nName={employee.EmpName}\nEmail={employee.Email}");
                    fileStream.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
