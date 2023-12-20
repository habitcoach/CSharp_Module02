using System.Diagnostics;
using windoesEventLog;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Creating event source
if (!EventLog.SourceExists("TestSource345"))
{
    EventLog.CreateEventSource("TestSource345", "TestLog");
}
//This is to create event source.  Opne the event viewr to see the log TestLog
Console.WriteLine("Event source created");

//try
//{
//    throw new DivideByZeroException("This is dividie by zero exception");
//  //  throw new AggregateException("This is an aggregate exception");

    
//}

//catch (DivideByZeroException ex)
//{

//    Logger.Log(ex);


//}

//catch (AggregateException ex)
//{

//    Logger.Log(ex);


//}
//finally {
//    Console.WriteLine("Messaged logged");
//}

 void MyMethod() { 


    Thread.Sleep(3000);

}



