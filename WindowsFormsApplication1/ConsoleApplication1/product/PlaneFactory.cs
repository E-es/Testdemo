using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PlaneFactory : VehicleCreator
{
    public override Car CreateCarFactory()
    {
        return new Car();
    }

    public override Plane CreatePlaneFactory()
    {
        return new Plane();
    }
}
