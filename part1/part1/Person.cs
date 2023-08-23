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
        public Animal Pet2 { get; set; }
        public TVShow FavoriteTVShow { get; set; }


        public void RenamePet(string newNamee)
        {
            Pet.NowName = newNamee;
        }
        public void RenamePet2(string newNamee)
        {
            Pet2.NowName = newNamee;
        }

        public void CallPet(string nameToCall)
        {
            if (nameToCall == Pet.NowName || nameToCall == Pet.PreviousName)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("No reaction...");
            }
        }

        public void CallPet2(string nameToCall)
        {
            if (nameToCall == Pet2.NowName || nameToCall == Pet2.PreviousName)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("No reaction...");
            }
        }
    }
}
