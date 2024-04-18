using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Pineapple : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("portagal");
        }
        public Pineapple(string name,string vitamine, string vitamind)
        {
            Sort = name;
            VitaminD = vitamind;
            VitaminE = vitamine;
        }
        public string VitaminE;
        public string VitaminD;

    }
}
