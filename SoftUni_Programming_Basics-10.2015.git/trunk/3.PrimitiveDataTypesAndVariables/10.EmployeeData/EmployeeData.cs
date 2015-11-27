using System;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            string personalID = "8306112507"; //Using string because will no need to change this value
            //int and uint =  32-bit integers
            uint employeeNumber = 27563571; //We do not use int because we do not need negative numbers
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
