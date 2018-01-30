using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCreator create = new Factory();

            var car1                = create.CreateFactory<Car>();
            car1.Type               = "personal vehicle";
            car1.Licences           = "NF123456";
            car1.Engine_power       = "147 kW";
            car1.Maximal_speed      = "200 km/h";
            car1.Colour             = "green ";
            car1.Print();
            car1.Drive();


            var car2                = create.CreateFactory<Car>();
            car1.Type               = "personal vehicle";
            car2.Licences           = "NF654321";
            car2.Engine_power       = "150 kW";
            car2.Maximal_speed      = "195 km/h";
            car2.Colour             = "blue ";
            car2.Print();
            car2.Drive();

            Console.WriteLine("Compare these two cars to check if this is the same vehicle:{0}", car1 == car2);

            var plane1              = create.CreateFactory<Plane>();
            plane1.Type             = "jet plane";
            plane1.Licences         = "LN1234";
            plane1.Engine_power     = "1000 kW";
            plane1.Wingspan         = "30m";
            plane1.Load_capacity    = "2t";
            plane1.Weight           = "10t";
            plane1.Print();
            plane1.Fly();


            var boat1               = create.CreateFactory<Boat>();
            boat1.Licences          = "ABC123";
            boat1.Engine_power      = "100 kW";
            boat1.Maximal_speed     = "30 knot per hour";
            boat1.Weight            = "500 kg gross tonnage";

            boat1.Print();

            Console.ReadLine();
        }
    }
}
