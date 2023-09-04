using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tansformers
{
    public interface ITransformer
    {
        void Run();
        int Wheels { get; }
        int MaxSpeed { get; }
    }
}
