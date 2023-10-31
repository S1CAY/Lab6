using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_04
{
    public class TaskScheduler<TTask, TPriority>
    {
        private PriorityQueue<TTask, TPriority> taskQueue = new PriorityQueue<TTask, TPriority>();

        public delegate void TaskExecution(TTask task);

        public void AddTask(TTask task, TPriority priority)
        {
            taskQueue.Enqueue(task, priority);
        }

        public void ExecuteNext(TaskExecution executeTask)
        {
            var nextTask = taskQueue.Dequeue();
            if (nextTask != null)
            {
                executeTask(nextTask);
            }
            else
            {
                Console.WriteLine("No tasks to execute.");
            }
        }

        public int TaskCount
        {
            get { return taskQueue.Count; }
        }

        public void PrintTaskCount()
        {
            Console.WriteLine($"Total tasks in the queue: {TaskCount}");
        }
    }

}
