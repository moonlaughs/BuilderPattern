using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Car
    {
        public string Maker { get; set; }
        public string Color { get; set; }
        public int TopSpeed { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public string Owner { get; set; }
        public string Fuel { get; set; }
        public string LicencePlate { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string maker, string color, int topSpeed, double price, int year, string owner, string fuel, string licencePlate, string registrationNumber)
        {
            Maker = maker;
            Color = color;
            TopSpeed = topSpeed;
            Price = price;
            Year = year;
            Owner = owner;
            Fuel = fuel;
            LicencePlate = licencePlate;
            RegistrationNumber = registrationNumber;
        }

        public Car() //called: default constructor
        {

        }

        public Car drive()
        {
            //Car car = new Car();
            //car.TopSpeed = 100;
            Console.WriteLine("I drive..");
            //return car;
            return this;
        }

        public Car breaking()
        {
        //    Car car = new Car();
        //    car.TopSpeed = 50;
            Console.WriteLine("I break..");
            //return car;
            return this;
        }
    }
}
