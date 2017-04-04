using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    // This interface defines the necessary methods for a Queue of strings
    interface IQueue
    {
        // puts a new string onto the end of the queue
        void Enqueue(string str);

        // returns the top item off a queue. returns a null if there is no data
        string Dequeue();

        // tells if the queue is empty. return true if empty, otherwise returns false
        Boolean IsEmpty();
    }
}
