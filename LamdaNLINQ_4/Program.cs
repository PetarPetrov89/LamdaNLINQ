using System;
using System.Linq;
using System.Collections.Generic;

namespace LamdaNLINQ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog {Name = "Rex", Age = 4, Colour = "Brown", Adress = "Ruse"},
                new Dog {Name = "Sharo", Age = 0, Colour = "Grey", Adress = "Sofia"},
                new Dog {Name = "Pesho", Age = 3, Colour = "Gold", Adress = "Shumen"}
            };

            var names = dogs.Select(d => d.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var newDogList = dogs.Select(
                d => new { Age = d.Age, FirstLetter = d.Name[0] });

            foreach (var newDog in newDogList)
            {
                Console.WriteLine(newDog);
            }

        }
    }
}
