using part1;

class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Animal
        {
            Name = "Fluffy The Cat",
            Age = 3,
            Color = Color.White
        };

        Animal cat2 = new Animal
        {
            Name = "Dongle The Cat",
            Age = 5,
            Color = Color.Black
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
            Pet = cat,
            FavoriteTVShow = favoriteTVShow
        };

        Person person2 = new Person
        {
            Name = "Alice",
            Surname = "in Wonderland",
            Age = 54,
            Pet = cat2,
            FavoriteTVShow = favoriteTVShow2
        };

        Console.WriteLine($"{person.Name} is petting his pet - {person.Pet.Name}");
        Console.WriteLine($"{person.Name}'s favorite show is {person.FavoriteTVShow.Name}");
        Console.WriteLine("\n");
        Console.WriteLine($"{person2.Name} is petting her pet - {person2.Pet.Name}");
        Console.WriteLine($"{person2.Name}'s favorite show is {person2.FavoriteTVShow.Name}");
    }
}