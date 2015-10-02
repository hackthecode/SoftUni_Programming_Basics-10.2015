using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        // 254 decimal = FE hex
        int hexNumber = 0xFE;
        // Convert hex value in decimal
        Console.WriteLine("{0}", hexNumber + " = 0xFE");
    }
}
