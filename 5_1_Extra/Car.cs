using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Extra
{
    public class Car
    {
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private double _BuyingPrice;
        public double BuyingPrice
        {
            get
            {
                return _BuyingPrice;
            }
            set
            {
                _BuyingPrice = value;
            }
        }
        private double _MaxSpeed;
        public double MaxSpeed
        {
            get
            {
                return _MaxSpeed;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Default value is 140");
                }
                else
                {
                    _MaxSpeed = value;
                }
                
            }
        }

        private double _CurrentSpeed;
        public double CurrentSpeed
        {
            get
            {
              
                return _CurrentSpeed;


            }
            set
            {
                if (_CurrentSpeed < 0)
                {
                    Console.WriteLine("0 Can't be a max speed");
                }
                else
                {
                    _CurrentSpeed = value;
                }

            }
        }

        private string _Color;
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                if (value =="Black" || value =="White" || value =="Green")
                {
                    _Color = value;
                }
                else
                {
                    Console.WriteLine("No color of this type is available");
                }

            }
        }

        private double _Distance;
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
        public double _CarActPrice;
        public double CarActPrice
        {
            get
            {
                return _CarActPrice;
            }
            set
            {
               if (Distance==0)
                {
                    _CarActPrice = BuyingPrice;
                }
                // Car actual price depends on the distance a car has already traveled. With each kilometer car actual price is descreasing on 0.1 points
                else
                {
                    _CarActPrice = BuyingPrice;
                    while (Distance>0)
                    {
                        _CarActPrice = _CarActPrice - 0.1;
                        Distance--;
                    }
                   
                }
            }
        }

        public Car (string name, double buyingPrice, double maxSpeed)
        {
            Name = name;
            BuyingPrice = buyingPrice;
            MaxSpeed = maxSpeed;
            
        }

        public Car(string name, double buyingPrice, double maxSpeed,string color,double distance, double carActPrice)
        {
            Name = name;
            BuyingPrice = buyingPrice;
            MaxSpeed = maxSpeed;
            Color = color;
            Distance = distance;
            CarActPrice = carActPrice;

        }


        public Car()
        {
            Name = "Toyota";
            BuyingPrice = 10000;
            MaxSpeed = 140;
            Color = "Green";
            Distance = 0;
            TaxPrice = 0;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Car make: {Name}\nBuying price: {BuyingPrice}$\nMax Speed: {MaxSpeed} KM/H\nColor: {Color}\nDistance: {Distance} KM\nCar actual price: {CarActPrice:C}" );
        }

        public void tripCost()
        {
            Console.WriteLine("Input the distance you wants to travel: ");

        }



    }
}
