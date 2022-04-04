using System;

namespace csharpinheritance
{
    abstract class Vehicle
    {
        protected string brand;

        protected Vehicle(String brand)
        {
            this.brand = brand;
        }

        public String getBrand()
        {
            return this.brand;
        }

        public void honk()
        {
            Console.WriteLine("Vehicle honk!");
        }
        
    }

    class Car : Vehicle
    {
        
        public Car(string brand) : base(brand)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford");
            car.honk();
            Console.WriteLine("Car brand: "+ car.getBrand());
        }
    }
}
