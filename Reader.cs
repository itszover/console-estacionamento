using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_GIS
{
    internal class Reader
    {
        public static string Plate()
        {
            Console.Write("A placa do veículo: ");
            return Console.ReadLine() ?? "000ABC";
        }
        public static string Model()
        {
            Console.Write("O modelo do veículo: ");
            return Console.ReadLine() ?? "Modelo";
        }

        public static string Brand() 
        {
            Console.Write("A marca do veículo: ");
            return Console.ReadLine() ?? "Marca";
        }

        public static int Hours()
        {
            Console.Write("A quantidade de horas que o veículo permaneceu estacionado: ");
            return int.Parse(Console.ReadLine()!);
        }

        public static string VehicleType()
        {
            Console.Write("O tipo de veículo [1] Carro | [2] Moto]: ");
            return Console.ReadLine() ?? "1";
        }

        public static string Option()
        {
            Console.Write("Escolha uma opção: ");
            return Console.ReadLine() ?? "3";
        }
    }
}
