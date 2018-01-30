using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Factory : VehicleCreator
{
    public override T CreateFactory<T>()
    {
        return new T();
        //switch (_type)
        //{
        //    case "personal vehicle":
        //        return new Car();
        //    case "jet plane":
        //        return new Plane();
        //    case "boat":
        //        return new Plane();
        //    default:
        //        return new T(string _type);
        //}
    }
}
