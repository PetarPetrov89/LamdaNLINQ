using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace LamdaNLINQ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog {Name = "Rex", Age = 4, Colour = "Brown", Adress = "Ruse"},
                new Dog {Name = "Sharo", Age = 0, Colour = "Grey", Adress = "Sofia"},
                new Dog {Name = "Pesho", Age = 3, Colour = "Gold", Adress = "Shumen"},
                new Dog {Name = "Gosho", Age = 3, Colour = "Red", Adress = "Shumen"},
                new Dog {Name = "Sasho", Age = 4, Colour = "Pinn", Adress = "Shumen"},
                new Dog {Name = "Rumen", Age = 2, Colour = "Yello", Adress = "Shumen"},
                new Dog {Name = "Alex", Age = 5, Colour = "Black", Adress = "Shumen"},
                new Dog {Name = "Simon", Age = 3, Colour = "Gold", Adress = "Shumen"},
                new Dog {Name = "Gergi", Age = 7, Colour = "Gold", Adress = "Shumen"}
            };

            var groupDogs = dogs.GroupBy(d => d.Age, d => d.Name);

            Dictionary<int, List<string>> dictionary = groupDogs.ToDictionary(g => g.Key, g => g.ToList());

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);
                foreach (var name in kvp.Value)
                {
                    Console.WriteLine($"--{name}");
                }
            }
        }

        public class Dog
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Colour { get; set; }

            public string Adress { get; set; }
        }
    }


}
