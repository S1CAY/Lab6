using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_04
{
  
    class Program
    {
        static void Main(string[] args)
        {
            TaskScheduler<string, int> taskScheduler = new TaskScheduler<string, int>();
            taskScheduler.AddTask("Task 1", 3);
            taskScheduler.AddTask("Task 2", 1);
            taskScheduler.AddTask("Task 3", 2);

            Console.WriteLine("Tasks added to the scheduler.");

            taskScheduler.PrintTaskCount();

            Console.WriteLine("Executing tasks:");

            taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing: {task}"));

            taskScheduler.PrintTaskCount();

            taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing: {task}"));

            taskScheduler.PrintTaskCount();

            taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing: {task}"));

            taskScheduler.PrintTaskCount();

            taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing: {task}"));

            taskScheduler.PrintTaskCount();
        }
    }
}
 
