using System;

namespace ConsoleApp1.Models
{
    internal class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Moow");
        }
        public override void EatFood(Food food)
        {
            Console.WriteLine("Eating grass");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Milk Produced");
        }
    }
}