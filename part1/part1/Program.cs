using part1;

class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Animal
        {
            Name = "Fluffy",
            Age = 3,
            Color = Color.White
        };

        Animal cat2 = new Animal
        {
            Name = "Dongle",
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
            Name = "John",
            Surname = "Doe",
            Age = 30,
            Pet = cat,
            FavoriteTVShow = favoriteTVShow
        };

        person.PetAnimal(cat);
    }
}