using ConsoleApp1.Models;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Qizil ehmedi","32","45");
            Orange orange = new Orange("Portagal","372");
            Pineapple pineapple = new Pineapple("Ananas","56", "45");
            Fruit[] basket = { apple, orange, pineapple };

            /*foreach (var fruit in basket)
            {
                if (fruit is  Apple apple1)
                {
                    apple1.Taste();
                    Console.WriteLine(apple1.Sort);
                    Console.WriteLine(apple1.VitaminA);
                }
                else if ( fruit is Orange orange1)
                {
                    orange.Taste();
                    Console.WriteLine(orange.Sort);

                    Console.WriteLine(orange.VitaminC);
                }
                else if( fruit is Pineapple pineapple1 )
                {
                    Console.WriteLine(pineapple1.Sort);

                    pineapple.Taste();
                }
            }*/
            foreach (var fruit in basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine(fruitType.Name);

                FieldInfo[] fields = fruitType.GetFields();
                foreach (var item in fields)
                {
                    
                   
                    Console.WriteLine(item.GetValue(fruit));
                }
            }
        }
    }   
}
