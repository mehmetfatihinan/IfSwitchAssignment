using System;
using System.Reflection.Metadata;
using static System.Math;

namespace SwitchApp
{
    class FoodStore
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Rüya Manavina Hos Geldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diger bütün meyveler = 4 TL");

            Console.Write("Hangi meyveyi satin almak istersiniz ? (Elma/Armut/Cilek/Muz/Diger): ");
 
            string user_food = Console.ReadLine().ToLower();

            switch (user_food)
            {
                case "elma":
                    Console.WriteLine("Elma fiyati: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Armut fiyati: 3 TL");
                    break;
                case "cilek":
                    Console.WriteLine("Cilek fiyati: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Muz fiyati: 3 TL");
                    break;
                case "Diger":
                    Console.WriteLine("Diger meyveler fiyati: 4 TL");
                    break;
                default:
                    Console.WriteLine("Gecersiz meyve ismi!");
                    break;
            }

            /* if (user_food) == "elma"
                { Console.WriteLine("Elma fiyati: 2 TL"); }
            else if (user_food == "armut")
                { Console.WriteLine("Armut fiyati: 3 TL"); }
            else if (user_food == "cilek")
                { Console.WriteLine("Cilek fiyati: 2 TL"); }
            else if (user_food == "muz")
                { Console.WriteLine("Muz fiyati: 3 TL"); }
            else if (user_food == "diger")
                { Console.WriteLine("Diger meyveler fiyati: 4 TL"); }
            else
                { Console.WriteLine("Gecersiz meyve ismi!"); }
            Switch case cok daha rahat bir kullanım sunuyor. Kod hem daha okunaklı hemde daha az satırda yazılabiliyor. Bu nedenle switch case kullanımı tercih edilir.
             */

        }


    }

}


