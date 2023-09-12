using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public bool IsFast { get; set; } = true;
        public int NumberOfDoors { get; set; } = 0;

        public void Build()
        {
            Console.WriteLine("Building a motorcycle!");
        }
    }
}
