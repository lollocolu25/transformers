using System;

namespace Tansformers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jet j = new Jet(9,900);
            Car c = new Car(4, 450);
            Boat b = new Boat(0,200);
            j.Run();
            c.Run();
            b.Run();
        }
    }
}
