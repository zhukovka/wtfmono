using System;
using System.ServiceModel;

namespace BinaryConverterClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                BinaryConverterLib.BinaryConverterLib lib = new BinaryConverterLib.BinaryConverterLib();
                string addr = "localhost:8042";
                Console.Write("Enter a number: ");
                string n = Console.ReadLine();
                int m = Int32.Parse(n);
                string res = lib.RequestToBinaryConverter(addr, m);
                Console.WriteLine($"Binary of {m} is: {res}");
                Console.ReadKey();
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
