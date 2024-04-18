using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Meet : Food
    {
        public string Type { get; set; }
        public Meet(int calorie, string type) : base(calorie)
        {
            Type = type;
            
        }
        
    }
}
