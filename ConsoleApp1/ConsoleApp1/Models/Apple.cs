using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Apple : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Sweet");
        }
        public Apple(string name, string vitamina,string  vitaminb) 
        {
            Sort = name;
            VitaminA = vitamina;
            VitaminB = vitaminb;
        }
        public string VitaminA;
       
        public string VitaminB;
    }
}
