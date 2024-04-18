using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Animal : Food
	{
        public string Breed { get; set; }
        public Animal(string breed) 
        {
            Breed = breed;
        }
        public abstract void MakeSound();
        public abstract void EatFood(Food food);

    }
}
