using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Fido";
            dog.Age = 3;

            Cat cat = new Cat();
            cat.Name = "Whiskers";
            cat.Age = 2;

            dog.Eat(); // Output: Fido is eating.
            dog.Bark(); // Output: Fido is barking.

            cat.Eat(); // Output: Whiskers is eating.
            cat.Meow(); // Output: Whiskers is meowing.
        }
    }
}
