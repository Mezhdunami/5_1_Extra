using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Extra
{


    public class Car
    {
        private string _name;
        public string Name
        {
            get { return _name; }

        }


        private double _buyingPrice;
        public double BuyingPrice
        {
            get
            {
                return _buyingPrice;
            }
        }
        private double _MaxSpeed;
        public double MaxSpeed
        {
            get
            {
                if (_MaxSpeed< 0 || _MaxSpeed > 300000)
                {
                    Console.WriteLine("Enter a correct value");
                    _MaxSpeed = 0;
                    
                }
                return _MaxSpeed;
            }
       
        }

        private double _CurrentSpeed;
        public double CurrentSpeed    //e, but it shouldn't be less than 0 and more than Max speed. 
        {
            get
            {
                return _CurrentSpeed;
            }
            set
            {
                if (value < 0 || value > MaxSpeed)
                {
                    Console.WriteLine("ERROR! Try again");
                }
                else
                {
                    _CurrentSpeed = value;
                }

            }
        }

        

        private double _Distance = 0;
        public double Distance
        {
            get
            {
                return _Distance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Can't be less than 0");
                }
                else
                {
                    _Distance = value;
                }
               
            }
        } 

        private double _TaxPrice;
        public double TaxPrice
        {
            get
            {
                return _TaxPrice;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Can't be less than 0");
                }
                else
                {
                    _TaxPrice = value;
                }
            }
        }

       

        private CarColor _color = CarColor.Green;
        public CarColor Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }




        public Car(string name = "Toyota", double buyingPrice = 10000, double maxSpeed = 140)
        {
            _name = name;
            _buyingPrice=buyingPrice;
            _MaxSpeed = maxSpeed;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Car make: {Name}\nBuying price: {BuyingPrice}$\nMax Speed: {MaxSpeed} KM/H\nColor: {Color}\nDistance: {Distance} KM" );
        }
        //- Calculate Car actual price. If car have been not used Car actual price equals to Car buying price.

        public double GetActualPrice()
        {
            if (Distance == 0)
            {
                return BuyingPrice;
            }
            else
            {
                double decrease = BuyingPrice * 0.1;
                return BuyingPrice - decrease;
            }
        }




        public void tripCost()
        {

            double ActPriceCoef = BuyingPrice / GetActualPrice();

            double MaxSpeedCoef = 0;
            if (MaxSpeed <=140)
            {
                MaxSpeedCoef = 1;
            }
            if (MaxSpeed>140 && MaxSpeed<180)
            {
                MaxSpeedCoef = 1.5;
            }
            if (MaxSpeed>180)
            {
                MaxSpeedCoef = 2;
            }
        

            Console.WriteLine("Input the distance you wants to travel: ");
            double Cost =double.Parse(Console.ReadLine());
            double answer = Cost * ActPriceCoef * MaxSpeedCoef * TaxPrice;

            Console.WriteLine($"{answer:C}");

        }

        

   


    }
}
