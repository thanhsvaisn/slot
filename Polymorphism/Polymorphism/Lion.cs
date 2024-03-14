using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Lion : Animal
    {
        // Constructor calling base class method
        public Lion(string name, double weight) : base(name, weight) { }

        // Method to display lion's sound

    }
}
