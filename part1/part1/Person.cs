using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Animal Pet { get; set; }
        public TVShow FavoriteTVShow { get; set; }

        public void PetAnimal(Animal animal)
        {
            Pet = animal;
            Console.WriteLine(animal);

        }
    }
}
