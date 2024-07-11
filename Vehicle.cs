using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_GIS
{
    internal abstract class Vehicle(string plate, string model, string brand)
    {
        public string Plate { get; set; } = plate;
        public string Model { get; set; } = model;
        public string Brand { get; set; } = brand;

        public void ShowInfo()
        {
            Color.Write($"| {Plate} - {Model} - {Brand}", MessageType.Success);
        }
    }
}
