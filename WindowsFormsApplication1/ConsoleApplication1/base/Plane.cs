using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Plane : Vehicle,Ifly
{
    public string Wingspan { get; set; }
    public string Type { get; internal set; }

    public override void Print()
    {
        Console.WriteLine($"registration {Licences}, {Engine_power} engine power, {Wingspan} wingspan, {Load_capacity} load capacity and {Weight} net weight, flying class of {Type}");
    }
    public void Fly()
    {
        Console.WriteLine("fly ");
    }
}
