using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class VehicleCreator
{
    public abstract T CreateFactory<T>() where T : new();
}
