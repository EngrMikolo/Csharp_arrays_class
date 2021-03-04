using System;

namespace Csharp_arrays_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] basketFruits = new string[5];

            Console.WriteLine("List five(5) of your favorite fruits");
            basketFruits[0] = Console.ReadLine();
            basketFruits[1] = Console.ReadLine(); 
            basketFruits[2] = Console.ReadLine(); 
            basketFruits[3] = Console.ReadLine(); 
            basketFruits[4] = Console.ReadLine(); 

            Console.WriteLine(basketFruits[3]);

            Console.WriteLine("Length of the array: "+ basketFruits.Length);

            //print all elements of the array
            for (int i = basketFruits.Length-1; i >= 0; i--)
            {
                Console.WriteLine(basketFruits[i]);
            }

            Console.WriteLine("");

            //using foreach
            Console.WriteLine("Using foreach: ");
            foreach (string fruit in basketFruits)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
