using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ls1
{
    class Car
    {
        public string CarName { get; set; }
        public int HorsePower { get; set; }
        public double EngineCapacity { get; set; }
        public string Fuel { get; set; }
        public string BodyType { get; set; }

        public Car(string carName, int horsePower, double engineCapacity, string fuel,string bodyType)
        {
            CarName = carName;
            HorsePower = horsePower;
            EngineCapacity = engineCapacity;
            Fuel = fuel;
            BodyType = bodyType;
        }   
        
    }
    internal class cs1
    {
        public static void task_1()
        {
            Car car1 = new Car("Honda", 150, 4.5, "Gas", "Sedan");
            Car car2 = new Car("BMW", 250, 5, "Gasoline", "Hatchback");
            Car car3 = new Car("Audi", 200, 4, "Gasoline", "Universal");
            void OutputInfo(Car car)
            {
                Console.WriteLine($"Car name:{car.CarName}");
                Console.WriteLine($"Horse power:{car.HorsePower}");
                Console.WriteLine($"Engine capacity:{car.EngineCapacity}");
                Console.WriteLine($"Fuel type:{car.Fuel}");
                Console.WriteLine($"Body type:{car.BodyType}");
            }

            Console.WriteLine("Hello we have 3 car,what car you want to see:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    OutputInfo(car1);
                    break;
                case 2:
                    OutputInfo(car2);
                    break;
                case 3:
                    OutputInfo(car3);
                    break;
                default:
                    Console.WriteLine("Wrong Car Number:");
                    break;
            }
        }
    }
}
