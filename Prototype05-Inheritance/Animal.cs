using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
