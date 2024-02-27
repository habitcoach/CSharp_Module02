using System;
using System.Diagnostics;

namespace debugging_tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           Debug.WriteLine("file create and logged in output");

            Trace.WriteLine("File created using trace");




            bool result = true;

            Debug.Assert(result, "something bad happened");

            //#region Notes
            ///*
            // There is also an Assert method in the Debug and Trace classes. You can use the Assert method to 
            //supply a condition (anlogical expression that must evaluate to either true or false) as well as a 
            //format string. If the condition is false, the Assertmethod terminates the program and displays a dialogue 
            //box with the message you provide. This method is handy whenyou need to find the moment in a 
            //long-running program where an unexpected event occurs.
            // */
            //#endregion

            Debug.WriteLineIf(true, "example for writelineIf");

            Trace.Flush();

            Trace.Listeners.Add(new ConsoleTraceListener());

            //#region Notes
            ///*
            // Here we are adding console to display the message as trace by  default add message to output.
            //Hence we flush the default listner and add a new listener that is console.
            // */
            //#endregion


            Trace.WriteLine("This is a trace message.");

            #region notes
            //Performance profiles
            /*
             Debug----> performance profiler--->check mark required profile

            Note that when you add myMethod the function can be seen in the CPU consumption ----> 
            
             */

            #endregion
        }
    }
}

