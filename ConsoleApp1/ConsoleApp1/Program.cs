using ConsoleApp1.Models;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Apple apple = new Apple("Qizil ehmedi","32","45");
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
            }#1#
            foreach (var fruit in basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine(fruitType.Name);

                FieldInfo[] fields = fruitType.GetFields();
                foreach (var item in fields)
                {
                    
                   
                    Console.WriteLine(item.GetValue(fruit));
                }
            }*/

                Grass yonca = new Grass(200);
                /*Meet yonca = new Meet(200,"toyuq");*/

                Meet baliq = new Meet(780, "baliq");

                Lion lion = new Lion("Barbary Lion");
                Cow cow = new Cow("Smetan");

                Animal[] animals = { cow, lion };
                foreach (var animal in animals)
                {
                    if (animal is Lion lion1)
                    {
                        lion1.MakeSound();
                        if (baliq is Meet)
                        {
                            lion1.EatFood(baliq);
                        }
                        else
                        {
                            Console.WriteLine("Lion only eat meet");
                        }
                        Console.WriteLine(lion1.Breed);
                    }

                    else if (animal is Cow cow1)
                    {
                        cow1.MakeSound();
                        cow1.ProduceMilk();
                        if (yonca is Grass)
                        {
                            cow1.EatFood(yonca);
                        }
                        else
                        {
                            Console.WriteLine("cow only eat grass");
                        }
                        Console.WriteLine(cow1.Breed);
                    }
                    Console.WriteLine("-----------");
                }
        }
    }
}
