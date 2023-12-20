/*
 call by reference: ref keyword should be used both in calling method and method definition

 */


using System;

namespace methodCallByValueAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 5;
            Test(ref num);
            Console.WriteLine("Num value is" + num);
        }

        public static void Test( ref int num)  //called by reference
        {

            Console.WriteLine("from the test method and the numbet is :{0}", num);
            num += 5;
            Console.WriteLine("from the test method and the changed numbet is :" + num);
        }
    }
}

