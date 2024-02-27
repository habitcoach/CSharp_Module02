using System.Diagnostics;
using windoesEventLog;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Creating event source
if (!EventLog.SourceExists("MySource"))
{
    EventLog.CreateEventSource("MySource", "MyTestLog");
}
//This is to create event source.  Opne the event viewr to see the log TestLog
Console.WriteLine("Event source created");

try
{
    throw new DivideByZeroException("This is dividie by zero exception");
      


}

catch (DivideByZeroException ex)
{

    Logger.Log(ex);
   


}

catch (AggregateException ex)
{

    Logger.Log(ex);


}
finally
{
    Console.WriteLine("Messaged logged");
}


