using _5_1_Extra;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        

        Car car1 = new Car("Supra",120000,130);


        //Calculate Car actual price.If car have been not used Car actual price equals to Car buying price.

        car1.Distance = 10;
        car1.TaxPrice = 10;
        car1.GetActualPrice();
        car1.GetInfo();
        Console.WriteLine("\n");

        car1.tripCost();









        //Console.WriteLine($"Name:{car1.Name}\nBuying price:{car1.BuyingPrice}\nMax Speed:{car1.MaxSpeed}\nActual price:{car1.CarActPrice}\nDistance:{car1.Distance}\nColor:{car1.Color}");





    }
}