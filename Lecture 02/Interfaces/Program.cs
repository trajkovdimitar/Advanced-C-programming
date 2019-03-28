using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {

        public interface ICar
        {
            string MotorNumber { get; set; }
            void Refuel();

        }
        public class Car : ICar
        {
            public string MotorNumber { get; set; }
            public void Refuel()
            {
                Console.WriteLine("This car drives on petrol.");
            }
            public Car() { }
            public Car(string engineNumber)
            {
                MotorNumber = engineNumber + "-N"; // Normal Car
            }
        }
        class ElectricCar : ICar
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int BatteryNumber { get; set; }
            public string MotorNumber { get; set; }
            public void Refuel()
            {
                Console.WriteLine("This car drives on battery.");
            }
            public ElectricCar(string brand,string model, int battNumber)
            {
                Brand = brand;
                Model = model;
                BatteryNumber = battNumber;
            }
            public ElectricCar(int battNumber)
            {
                MotorNumber = battNumber + "-N"; // Normal Car

            }
        }

        class HybridCar : ICar
        {
            public int BatteryLifeMonths { get; set; }
            public int BatteryDuration { get; set; }
            public string MotorNumber { get; set; }
            public void Refuel()
            {
                Console.WriteLine("This car runs on both petrol and electric power!");
            }
            public HybridCar(int batLifeMonths, int battDuration, string engineNum )
            {
                batLifeMonths = BatteryLifeMonths;
                battDuration = BatteryDuration;
                engineNum = MotorNumber;
            }
          
        }


        static void Main(string[] args)
        {
            HybridCar Toyota = new HybridCar(24,8,"100009");
            Console.WriteLine(Toyota.MotorNumber);
            Console.ReadLine();
        }

        
    }
}