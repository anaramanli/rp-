using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    abstract class Fruit
    {
        private decimal _price;
        private string _sort;

        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public string Sort { get; set; }
    
        public abstract void Taste();
    }
}
