using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class Child
    {
        // Attributes
        string name;
        string saying;

        // Constructor
        public Child(string name, string saying)
        {
            this.name = name;
            this.saying = saying;
        }

        public void Whine()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name + ": " + saying);
            }
        }
    }
}
