using _5_1_Extra;


class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("BMW",15000,200);
        Car car2 = new Car("Subaru", 11000, 210);
        Car car3 = new Car("Lexus", 27000, 200);
        Car car4 = new Car("Volkswagen", 10000, 150);
        Car car5 = new Car();
                              //  BP  , MS,       ,DIST , ACT
        Car car6 = new Car("Audi",120000,120,"Black",150000,0);  //Used car
        Car car7 = new Car();


       car6.GetInfo();
        

       


    }
}