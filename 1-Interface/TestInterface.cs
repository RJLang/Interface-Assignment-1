using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface
{
    class TestInterface
    {
        public static void FormatRecord(IFormatter format)
        {
            format.Format();
        }

        public static string GetRecordType()
        {
            Console.WriteLine("Please select one for the following options");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create new Phone number");
            Console.WriteLine("2. Create new social security record");
            var type = Console.ReadLine();

            return type;
        }
    }
}
