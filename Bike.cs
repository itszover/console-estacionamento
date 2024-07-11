using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_GIS
{
    internal class Bike(string plate, string model, string brand, int cylinders) : Vehicle(plate, model, brand)
    {
        public int Cylinders { get; set; } = cylinders;
    }
}
