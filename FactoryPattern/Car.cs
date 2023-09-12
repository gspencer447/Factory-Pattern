using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public bool IsFast { get; set; } = true;
        public int NumberOfDoors { get; set; } = 4;

        public void Build()
        {
            Console.WriteLine("Building a car!");
        }
    }

}
