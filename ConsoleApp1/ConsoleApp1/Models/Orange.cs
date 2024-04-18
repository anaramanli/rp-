using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Orange : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Sour");
        }
        public Orange(string name, string vitaminc)
        {
            Sort = name;
            VitaminC = vitaminc;
        }
        public string VitaminC;

    }
}
