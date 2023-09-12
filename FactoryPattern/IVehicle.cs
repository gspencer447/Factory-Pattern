using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IVehicle
    {
        public bool IsFast { get; set; }
        public int NumberOfDoors { get; set; }
        public void Build()
        {
            
        }
    }
}
