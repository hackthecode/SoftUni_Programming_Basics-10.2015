using System;
using System.Text;

namespace _01.DeclareVariables
{
    internal class DeclareVariables
    {
        public static void Main()
        {
            // Declare Variables
            //C# supports nine integral types: sbyte, byte, short, ushort, int, uint, long, ulong, and char.
            //The ushort type represents unsigned 16-bit integers with values between 0 and 65535.
            ushort ushortType = 52130;
            //The sbyte type represents signed 8-bit integers with values between –128 and 127.
            sbyte sbyteType = -115;
            //The int type represents signed 32-bit integers with values between –2147483648 and 2147483647.
            int intType = 4825932;
            //The byte type represents unsigned 8-bit integers with values between 0 and 255.
            byte byteType = 97;
            //The short type represents signed 16-bit integers with values between –32768 and 32767.
            short shortType = -10000;
            // Console Print 
            Console.OutputEncoding = Encoding.UTF8;
            char rightwardsArrow = '\u2192'; // char →
            Console.WriteLine(String.Format("{0, -10}", "ushort ") + rightwardsArrow + "{0, 10}", ushortType);
            Console.WriteLine(String.Format("{0, -10}", "sbyte ") + rightwardsArrow + "{0, 10}", sbyteType);
            Console.WriteLine(String.Format("{0, -10}", "int ") + rightwardsArrow + "{0, 10}", intType);
            Console.WriteLine(String.Format("{0, -10}", "byte ") + rightwardsArrow + "{0, 10}", byteType);
            Console.WriteLine(String.Format("{0, -10}", "short ") + rightwardsArrow + "{0, 10}", shortType);
        }
    }
}