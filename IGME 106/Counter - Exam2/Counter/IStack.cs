using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    // This interface defines a stack of strings.
    interface IStack
    {
        // pushes a new string onto the stack
        void Push(string str);

        // pops the top item off a stack. returns a null if there is no data
        string Pop();

        // tells if the stack is empty. return true if empty, otherwise returns false
        Boolean IsEmpty();
    }
}
