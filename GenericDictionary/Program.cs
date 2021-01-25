using System;
using System.Collections.Generic;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> sozcukler = new MyDictionary<string>();
            sozcukler.Add("Almak");

            Console.WriteLine(sozcukler.Lenght);

            sozcukler.Add("Vermek");

            Console.WriteLine(sozcukler.Lenght);

            foreach (var sozcuk in sozcukler.Items)
            {
                Console.WriteLine(sozcuk);
            }
            //List<string> liste = new List<string>();
                        
            //    Console.WriteLine(liste.Count);
            
            //Console.WriteLine("Hello World!");
        }
    }
}
