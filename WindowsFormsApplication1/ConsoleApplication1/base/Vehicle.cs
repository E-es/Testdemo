using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class  Vehicle
{
    public string Licences { get; set; }
    public string Engine_power { get; set; }
    public string Maximal_speed  { get; set; }
    public string Weight { get; set; }

    public string Load_capacity { get; set; }
    public abstract void Print();

}
