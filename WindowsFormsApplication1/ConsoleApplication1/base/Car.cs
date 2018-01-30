using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Car : Vehicle,Idrive
{
    public string Colour { get; set; }

    public string Type { get; set; }
    public override void Print()
    {
        Console.WriteLine($"licence plate {Licences}, {Engine_power} engine power, maximal speed of {Maximal_speed}, {Colour} colour and type of {Type}");
    }
    public void Drive()
    {
        Console.WriteLine("drive");
    }


    public Car()
    {
    }

    public Car(string _Licences, string _Engine_power, string _Maximal_speed = null, string _Colour = null)
    {
        this.Licences = _Licences;
        this.Engine_power = _Engine_power;
        this.Maximal_speed = _Maximal_speed;
        this.Colour = _Colour;
    }
}
