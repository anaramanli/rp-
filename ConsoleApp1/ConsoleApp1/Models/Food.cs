using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Food
    {

        public int Calorie;

        protected Food(int calorie)
        {
            Calorie = calorie;
        }

        protected Food()
        {
            
        }
    }
}
