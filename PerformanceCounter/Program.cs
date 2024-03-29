﻿using System.Diagnostics;



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

for (int i = 0; i < 100; i++)
{ counter.IncrementBy(2); }


#region Notes

/*

Open the performance monitor
Now at the bottom clear all the counter
Right click and click on add new counter
Now under available counter tab choose MyDemoCategoryCounter
Once chose wait and in the instance of selected object tab at the bottom choose "demo"
NOw set the debug and when you increment to 2 you can see the bump in the graph

 */

#endregion