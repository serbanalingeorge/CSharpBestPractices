using System;

namespace Prestige.Biz
{
    class Program
    {
        //cannot be modified/for compile-time 
        public const int ConstantNumber = 100;
        //can be modified inside constructor/for runtime
        public static readonly int ReadOnlyNumber;

        static Program()
        {
            ReadOnlyNumber = 5;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine(ConstantNumber);
            Console.WriteLine(ReadOnlyNumber);*/

            Agency agency = null;
            Console.WriteLine(agency?.Name);



            Console.ReadKey();
        }
    }
}
