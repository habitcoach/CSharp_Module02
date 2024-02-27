using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string statusMessage; // Declare a variable to store the status message

        // Call the method and pass statusMessage as an out parameter
        string result1 = GetMessage(out statusMessage);
        Console.WriteLine("Updated Status Message: " + statusMessage);
        Console.WriteLine("Result from GetMessage: " + result1);

        // Simulate another long-running process
        string result2 = DoAnotherTask(out statusMessage);
        Console.WriteLine("Updated Status Message: " + statusMessage);
        Console.WriteLine("Result from DoAnotherTask: " + result2);
    }

    // Method to update the status message and return a value
    static string GetMessage(out string message)
    {
        // Simulate a long-running process
        Thread.Sleep(2000);

        // Modify the message
        message = "Task completed successfully";

        // Return a value
        return "Result from GetMessage";
    }

    // Another long-running process that returns a value
    static string DoAnotherTask(out string message)
    {
        // Simulate a long-running process
        Thread.Sleep(3000);

        // Modify the message
        message = "Another task completed successfully";

        // Return a value
        return "Result from DoAnotherTask";
    }
}
