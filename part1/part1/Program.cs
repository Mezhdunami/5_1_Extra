using part1;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {

        Animal cat2 = new Animal
        {
            NowName = "Korjik",
            Age = 5,
            Color = Color.Black
        };

        Animal dog1 = new Animal
        {
            NowName = "Korjik"
            
        };

        Person person = new Person
        {
            Name = "Charles",
            Surname = "Bukowski",
            Age = 30,
            Pet = dog1,
        };

        Person person2 = new Person
        {
            Name = "Alice",
            Surname = "in Wonderland",
            Age = 54,
            Pet = dog1,
        };

        //- Firstly Charles pets the dog and gives it a name "Snoopy". 
        person.PetAnimal(dog1);
        person.RenamePet("Snoopy");
        //- Charles calls the pet with "Korjik" and "Snoopy", and gets "Hello". Charles calls the pet with "Bobik" - "no reaction"
        person.CallPet("Korjik");
        person.CallPet("Snoopy");
        person.CallPet("Bobik");
        Console.WriteLine();
        //- But Alice didn't know about it and also pet the Same dog
        //(Animals can be pet by different people). And Alice gave dog a name "Sushka".
        person2.PetAnimal(dog1);
        person2.RenamePet("Sushka");
        //- Alice calls the pet with "Sushka and gets "Hello". 
        person2.CallPet("Sushka");
        Console.WriteLine();
        //- Charles calls his pet with a name "Snoopy" and gets "Hello", but when he calls the pet with "Korjik" - "no reaction".
        person.CallPet("Snoopy");
        person.CallPet("Korjik");
        //- Charles was upset and found another animal - a cat with name "Korjik" as well. Charles pets the cat without renaming.
        person.PetAnimal(cat2);
        //- Alice also sees the beatiful cat "Korjik" and decides to pet it as well. She gives her pet a name "Kitty"
        person2.PetAnimal(cat2);
        person2.RenamePet("Kitty");
        //- Charles gives the pet a name "Meow".
        person.RenamePet("Meow");
        //- Charles calls the pet with "Korjik" - "no reaction".
        Console.WriteLine();
        person.CallPet("Korjik");
        //- Charles calls the pet with "Snoopy" - "no reaction"
        person.CallPet("Snoopy");
        //- Charles decides to pet the dog again instead of the cat.
        person.PetAnimal(dog1);
        //- Charles calls the pet with "Snoopy" -  "Hello"
        person.CallPet("Snoopy");



    }
}