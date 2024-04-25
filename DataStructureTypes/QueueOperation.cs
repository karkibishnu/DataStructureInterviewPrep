using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInterviewPrep.DataStructureTypes
{
    public static class QueueOperation
    {
        private static Queue<int> queue = new Queue<int>();
        public static Queue<int> InsertInQueue()
        {
            for(int i = 0; i < 5; i++)
            {
                queue.Enqueue(i+1);
            }
            return queue;
        }

        public static int PeekFirstQueue(Queue<int> queue)
        {
            int peekFirstValue = queue.Peek();
            return peekFirstValue;
        }
        
        public static int PeekLastQueue(Queue<int> queue)
        {
            int peekLastValue = queue.Last();
            return peekLastValue;
        }

        public static Queue<int> DeleteInQueue(Queue<int> queue)
        {
            queue.Dequeue();
            return queue;
        }

        public static bool IsQueueEmpty(Queue<int> queue)
        {
            return queue.Count() == 0;
        }
    }
}
