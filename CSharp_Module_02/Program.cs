using System;

namespace CSharp_Module_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 5;
            Test(  ref num); // for call by reference   Test(  ref num)
            Console.WriteLine("Num value is"+num);
        }

        public static void Test(  ref int num) {    // for call by reference  Test(ref  int num)
            
            Console.WriteLine("from the test method and the numbet is :{0}",num);
            num += 5;
            Console.WriteLine("from the test method and the changed numbet is :"+num);
        }
    }
}

