using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarFactory : VehicleCreator
{
    public override Car CreateCarFactory()
    {
        return new Car();
    }

    public override Plane CreatePlaneFactory()
    {
        throw new NotImplementedException();
    }
}
