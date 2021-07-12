using System;
using System.Text;

namespace RuralCarMechanicShop
{
    public class Vehicles
    {
        public string vehicleName { get; set; }
        public int year { get; set; }
        public string CompanyName { get; set; }
        public string ModelName { get; set; }
        public long ccNumber { get; set; }


        public static void OilChange()
        {
            Console.WriteLine("Oil Change Service");
        }

        public static void EngineTuneUp()
        {
            Console.WriteLine("Engine TuneUp Service");
        }

        public static void Transmission_CleanUp()
        {
            Console.WriteLine("Transmission CleanUp service");
        }
    }

}
