using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_GIS
{
    internal class Menu
    {
        private readonly Parking _parking;

        public Menu() 
        {
            _parking = new Parking();
        }

        public static string Start()
        {
            Color.Write(".__________________MENU_________________.", MessageType.Warn);
            Color.Write("\n|[1] Estacionar\t\t\t\t|\n|[2] Desestacionar\t\t\t|\n|[3] Exibir veículos estacionados\t|", MessageType.Warn);
            Color.Write("|[4] Encerrar Sistema\t\t\t|\n", MessageType.Critical);

            return Reader.Option();
        }

        public void Park()
        {
            Console.Clear();
            Color.Write("._____________DESESTACIONAR_____________.\n", MessageType.Info);

            string plate = Reader.Plate();

            if (_parking.CheckPlate(plate))
            {
                Color.Write("Ops! Este veículo já está estacionado. Tente uma placa diferente, por favor.", MessageType.Warn);
                return;
            }

            string model = Reader.Model();
            string brand = Reader.Brand();

            if (string.IsNullOrWhiteSpace(plate) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(brand))
            {
                Color.Write("Todos os campos são obrigatórios. Por favor, não deixe nenhum campo em branco.", MessageType.Error);
                return;
            }

            string type = Reader.VehicleType();

            switch (type)
            {
                case "1":
                    _parking.Park(new Car(plate, model, brand, 0));
                    Color.Write("Carro estacionado com sucesso!", MessageType.Success);
                    break;
                case "2":
                    _parking.Park(new Bike(plate, model, brand, 0));
                    Color.Write("Moto estacionada com sucesso!", MessageType.Success);
                    break;
                default:
                    Color.Write("Parece que você selecionou uma opção inválida. Vamos tentar de novo?", MessageType.Error);
                    break;
            }
        }

        public void Unpark()
        {
            Console.Clear();

            Color.Write("._____________DESESTACIONAR_____________.", MessageType.Info);

            if (_parking._vehicles.Count == 0)
            {
                Color.Write("\nParece que está vazio por aqui...\n", MessageType.Info);
                return;
            }

            Color.Write(".___________PLACAS___________.", MessageType.Info);

            for (int i = 0; i < _parking._vehicles.Count; i++)
            {
                Color.Write($"[{i + 1}] {_parking._vehicles[i].Plate}", MessageType.Success);
            }

            string plate = Reader.Plate();
            int hours = Reader.Hours();

            try
            {
                _parking.CalcFee(plate, hours);
                _parking.Unpark(plate);
                Color.Write("Veículo retirado com sucesso. Foi um prazer atendê-lo!", MessageType.Success);
            }
            catch (Exception e)
            {
                Color.Write($"{e.Message}. Por favor, tente novamente.", MessageType.Error);
            }
        }

        public void ParkedVehicles()
        {
            Console.Clear();
            Color.Write("._________VEÍCULOS ESTACIONADOS_________.", MessageType.Info);

            if (_parking._vehicles.Count == 0)
            {
                Color.Write("\nNenhum veículo estacionado no momento. O estacionamento está todo seu!\n", MessageType.Info);
                return;
            }

            foreach (var vehicle in _parking._vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}
