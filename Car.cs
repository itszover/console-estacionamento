using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_GIS
{
    internal class Car(string plate, string model, string brand, int doors) : Vehicle(plate, model, brand)
    {
        public int Doors { get; set; } = doors;
    }
}
