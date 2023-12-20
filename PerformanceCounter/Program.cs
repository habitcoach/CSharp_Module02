using System.Diagnostics;
using System.Diagnostics.PerformanceData;


if (PerformanceCounterCategory.Exists("MyDemoCategoryCounter"))
{

    PerformanceCounterCategory.Delete("MyDemoCategoryCounter");

}

var collection  = new CounterCreationDataCollection();

var data= new CounterCreationData("MyDemoCounter", "...", PerformanceCounterType.NumberOfItems32);

collection.Add(data);

PerformanceCounterCategory.Create("MyDemoCategoryCounter", "", PerformanceCounterCategoryType.MultiInstance, collection);

Console.WriteLine("counter created");

var counter = new PerformanceCounter("MyDemoCategoryCounter", "MyDemoCounter", "Demo",false);

counter.IncrementBy(2);
counter.IncrementBy(2);
counter.IncrementBy(2);




#region Notes

/*

Open the performance monitor
Now at the bottom clear all the counter
Right click and click on add new counter
Now under available counter tab choose MyDemoCatergoryCounter
ONce choosen wait and in the instanc of selecred objecrt tab at the bottom choose "demo"
NOw set the debug and when you increment to 2 you can see the bump in the graph

 */

#endregion