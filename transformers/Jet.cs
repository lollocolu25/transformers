using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tansformers
{
    internal class Jet : ITransformer
    {
        public int _wheels { get; set; }
        public int _maxSpeed { get; set; }

        public int Wheels => _wheels;

        public int MaxSpeed => _wheels;

        public Jet(int wheels, int maxSpeed)
        {
            _wheels = wheels;
            _maxSpeed = maxSpeed;
        }

        public void Run()
        {
            Console.WriteLine("on the sky");
        }
    }
}
