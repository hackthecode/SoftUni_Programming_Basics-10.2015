using System;

namespace _09.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Write("Please enter a int: ");
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(intNum + 1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double doubleNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleNum + 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + "*");
                    break;
                default: Console.WriteLine("Invalid Input!"); break;
            }
            // with ifs
            //int choice = int.Parse(Console.ReadLine());
            //if (choice == 1)
            //{
            //    Console.Write("Please enter a int:");
            //    int intNum = int.Parse(Console.ReadLine());
            //    Console.WriteLine(intNum + 1);
            //}
            //else if (choice == 2)
            //{
            //    Console.Write("Please enter a double:");
            //    double doubleNum = double.Parse(Console.ReadLine());
            //    Console.WriteLine(doubleNum + 1);
            //}
            //else if (choice == 3)
            //{
            //    Console.Write("Please enter a string:");
            //    string str = Console.ReadLine();
            //    Console.WriteLine(str + "*");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input!");
            //}
        }
    }
}
