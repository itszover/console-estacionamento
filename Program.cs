using Desafio_GIS;

Menu menu = new();
bool end = false;

Color.Write("BEM VINDO ao Estacionamento GIS!\n", MessageType.Info);

while (!end)
{
    switch (Menu.Start())
    {
        case "1":
            menu.Park();
            break;
        case "2":
            menu.Unpark();
            break;
        case "3":
            menu.ParkedVehicles();
            break;
        case "4":
            end = true;
            Color.Write("Obrigado por utilizar nosso sistema de estacionamento. Até a próxima!", MessageType.Success);
            break;
        default:
            Color.Write("Ops! Parece que você selecionou uma opção inválida. Vamos tentar novamente?", MessageType.Warn);
            break;
    }
}