using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Inheritance
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
            Console.ReadLine();
        }
    }
}
