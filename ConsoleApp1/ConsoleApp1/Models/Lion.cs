using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Lion : Animal
    {
        public Lion(string breed) : base(breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roaring");
        }

        public override void EatFood(Food food)
        {
            Console.WriteLine($"Eating Meet {typeof(Meet)}");
        }
    }
}
