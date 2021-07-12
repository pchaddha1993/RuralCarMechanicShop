using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RuralCarMechanicShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string creditCard = "1122334455667788";
            //string maskedNumber = "XXXXXXXX" + creditCard.Remove(5,10);
            //Console.WriteLine(maskedNumber);

            
            Customer customer1 = new Customer()
            {
                cname = "John",
                cage = 22,
            };


            Customer customer2 = new Customer()
            {
                cname = "Mark",
                cage = 30,
            };
            Customer customer3 = new Customer()
            {
                cname = "Michael",
                cage = 28,
            };

            Customer customer4 = new Customer()
            {
                cname = "Alan",
                cage = 35,
            };


            List<Customer> Customers = new List<Customer>(4);
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);

            Cars car = new Cars()
            {
                vehicleName = "Car",
                year = 1992,
                CompanyName = "FORD",
                ModelName = "Mustang",
                ccNumber = 4022667890124453,
                

        };
            School_Buses bus = new School_Buses()
            {
                vehicleName = "Bus",
                year = 2010,
                CompanyName = "TATA",
                ModelName = "Marcopolo",
                ccNumber = 4022667334312445,

            };
            PickUpTrucks truck = new PickUpTrucks()
            {
                vehicleName = "Truck",
                year = 1997,
                CompanyName = "Isuzu",
                ModelName = "D-Max",
                ccNumber = 4022667898764453,
            };
            Tractors tractor = new Tractors()
            {
                vehicleName = "Tractor",
                year = 1995,
                CompanyName = "Mahindra",
                ModelName = "TR60",
                ccNumber = 4022667899874453,
            };

            List<Vehicles> vehicles = new List<Vehicles>(4);
            vehicles.Add(car);
            vehicles.Add(bus);
            vehicles.Add(truck);
            vehicles.Add(tractor);

            static string encrypt(long creditCard)
            {
                long cc = creditCard;
                string vOut = cc.ToString();
                var reg = new Regex(@"(?<=\d{4}\d{0})\d{0}\d{4}(?=\d{4})");
               
                vOut = reg.Replace(vOut, new MatchEvaluator((m) => new String('*', m.Length)));
                return vOut;
            }

            foreach (Customer c in Customers)
            {
                Console.WriteLine("Customer Name :{0} and Age :{1} can access following :", c.cname, c.cage);
                foreach (var v in vehicles)
                {
                    
                    Console.WriteLine("{0} Manufacturing year is {1} , Company Name is {2}, Model Name is {3} and Credit card details is {4}\n", v.vehicleName,v.year, v.CompanyName, v.ModelName, encrypt(v.ccNumber));
                   
                }

                Console.WriteLine("Running common functions for all vehicles:\n");
                Vehicles.OilChange();
                Vehicles.EngineTuneUp();
                Vehicles.Transmission_CleanUp();

                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Vehicles performs below operations:\n");
                car.CarOperation();
                bus.BusOperation();
                truck.TruckOperation();
                tractor.TractorOperation();
                
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
