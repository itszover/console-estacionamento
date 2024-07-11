using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_GIS
{
    internal class Parking
    {
        private readonly decimal _HOURLY_RATE = 5;
        private readonly int _SPACES = 12;
        public readonly List<Vehicle> _vehicles = [];

        public void Park(Vehicle vehicle)
        {
            if (_vehicles.Count >= _SPACES)
            {
                Console.WriteLine("Estacionamento lotado.");
                return;
            }

            _vehicles.Add(vehicle);
            Console.Clear();
            Color.Write($"Vagas disponíveis: {_SPACES - _vehicles.Count}", MessageType.Info);
        }

        public void Unpark(string plate)
        {
            if (_vehicles.Count == 0)
            {
                throw new Exception("Nenhum veículo estacionado.");
            }

            var vehicle = _vehicles.Find(vehicle => vehicle.Plate == plate) ??
                throw new Exception($"Não há veículo com essa placa. | {plate}");

            _vehicles.Remove(vehicle);
        }

        public bool CheckPlate(string plate)
        {
            return _vehicles.Any(vehicle => vehicle.Plate == plate);
        }

        public void CalcFee(string plate, int hours)
        {
            if (!CheckPlate(plate))
            {
                throw new Exception("Veículo não está estacionado.");

            }

            decimal fee = hours * _HOURLY_RATE;

            Console.WriteLine($"Veiculo com placa {plate} | Valor a ser pago: R$ {fee}");
        }
    }
}
