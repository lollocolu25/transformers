using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tansformers
{
    internal class Boat : ITransformer
    {
        public int _wheels { get; set; }
        public int _maxSpeed { get; set; }

        public int Wheels => _wheels;

        public int MaxSpeed => _maxSpeed;

        public Boat(int wheels, int maxSpeed)
        {
            _wheels = wheels;
            _maxSpeed = maxSpeed;
        }

        public void Run()
        {
            Console.WriteLine("in the sea");
        }
    }
}
