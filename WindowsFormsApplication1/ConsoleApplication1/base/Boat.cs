using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Boat : Vehicle, Idrive
{

    public override void Print()
    {
        Console.WriteLine($"registration {Licences}, {Engine_power} engine power, maximal speed of {Maximal_speed} and {Weight}");
    }
    public void Drive()
    {
        Console.WriteLine("drive");
    }

}
