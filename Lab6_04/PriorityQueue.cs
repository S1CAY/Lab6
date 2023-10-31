using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_04
{
    public class PriorityQueue<TElement, TPrior>
    {
        private SortedDictionary<TPrior, Queue<TElement>> priorityQueue = new SortedDictionary<TPrior, Queue<TElement>>();

        public void Enqueue(TElement element, TPrior priority)
        {
            if (!priorityQueue.ContainsKey(priority))
            {
                priorityQueue[priority] = new Queue<TElement>();
            }
            priorityQueue[priority].Enqueue(element);
        }

        public TElement Dequeue()
        {
            foreach (var key in priorityQueue.Keys)
            {
                if (priorityQueue[key].Count > 0)
                {
                    return priorityQueue[key].Dequeue();
                }
            }
            return default(TElement);
        }

        public int Count
        {
            get { return priorityQueue.Values.Sum(queue => queue.Count); }
        }
    }

}


