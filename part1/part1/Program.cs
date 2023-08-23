using part1;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Animal
        {
            NowName = "Fluffy The Cat",
            Age = 3,
            Color = Color.White
        };

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

        TVShow favoriteTVShow = new TVShow
        {
            Name = "Game of Thrones",
            ChannelNumber = 5
        };

        TVShow favoriteTVShow2 = new TVShow
        {
            Name = "Black Mirror",
            ChannelNumber = 60
        };

        Person person = new Person
        {
            Name = "Charles",
            Surname = "Bukowski",
            Age = 30,
            Pet = dog1,
            Pet2 = cat2,
            FavoriteTVShow = favoriteTVShow
        };

        Person person2 = new Person
        {
            Name = "Alice",
            Surname = "in Wonderland",
            Age = 54,
            Pet = dog1,
            Pet2 = cat2,
            FavoriteTVShow = favoriteTVShow2
        };

        //- Firstly Charles pets the dog and gives it a name "Snoopy". 
        Console.Write($"{person.Name} pets {dog1.NowName}, ");
        person.RenamePet("Snoopy");
        Console.Write($"and gives {dog1.PreviousName} a new name which is {dog1.NowName}\n\n");
        //- Charles calls the pet with "Korjik" and "Snoopy", and gets "Hello". Charles calls the pet with "Bobik" - "no reaction"
        person.CallPet("Korjik");
        person.CallPet("Snoopy");
        person.CallPet("Bobik");
        Console.WriteLine("");
        //- But Alice didn't know about it and also pet the Same dog
        //(Animals can be pet by different people). And Alice gave dog a name "Sushka".
        Console.Write($"{person2.Name} pets {dog1.NowName}, ");
        person2.RenamePet("Sushka");
        Console.Write($"and gives {dog1.PreviousName} a new name which is {dog1.NowName}\n\n");
        //- Alice calls the pet with "Sushka and gets "Hello". 
        person2.CallPet("Sushka");
        Console.WriteLine();
        //- Charles calls his pet with a name "Snoopy" and gets "Hello", but when he calls the pet with "Korjik" - "no reaction".
        person.CallPet("Snoopy");
        person.CallPet("Korjik");
        Console.WriteLine();
        //- Charles was upset and found another animal - a cat with name "Korjik" as well. Charles pets the cat without renaming.
        Console.WriteLine($"{person.Name} pets his new animal named {person.Pet2.NowName}\n");
        //- Alice also sees the beatiful cat "Korjik" and decides to pet it as well. She gives her pet a name "Kitty"
        Console.Write($"{person2.Name} pets her new animal named {person2.Pet2.NowName}");
        person2.RenamePet2("Kitty");
        Console.Write($" She gives her pet a name {person2.Pet2.NowName}");
        Console.WriteLine();
        //- Charles gives the pet a name "Meow".
        Console.Write($"{person.Name} gives the pet a name ");
        person.RenamePet2("Meow");
        Console.Write(person.Pet2.NowName);
        //- Charles calls the pet with "Korjik" - "no reaction".
        Console.WriteLine("\n");
        person.CallPet2("Korjik");
        //- Charles calls the pet with "Snoopy" - "no reaction"
        Console.WriteLine("\n");
        person.CallPet2("Snoopy");
        //- Charles decides to pet the dog again instead of the cat.
        Console.WriteLine(person.Name + " Pets " + person.Pet.NowName + " instead of " + person.Pet2.NowName);
        //- Charles calls the pet with "Snoopy" -  "Hello"
        person.CallPet("Snoopy");
    }
}