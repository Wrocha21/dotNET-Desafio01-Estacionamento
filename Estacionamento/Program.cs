using System.Diagnostics;
using Estacionamento.Models;

Console.WriteLine("Bem vindo ao Sistema de Estacionamento");
Console.WriteLine(" ");
Console.Write($"Digite o preço inicial: ");
decimal precoInicial = Convert.ToInt32(Console.ReadLine());
Console.Write($"Digite o preço Por hora: ");
decimal precoPorHora = Convert.ToInt32(Console.ReadLine());

List<string> carros = [];
Console.Clear();
while (true)
{

  Console.WriteLine("========MENU========");
  Console.WriteLine("[1]Cadrastar veículo");
  Console.WriteLine("[2]Remover veículo");
  Console.WriteLine("[3]Listar veiculos");
  Console.WriteLine("[4]Encerrar");
  Console.WriteLine("========MENU========");
  Console.WriteLine(" ");
  Console.Write("Sua opção:");
  int opcao = Convert.ToInt32(Console.ReadLine());


  switch (opcao)
  {
    case 1:
      Console.Write("Digite a Placa do veículo para estacionar: ");
      var placa = Console.ReadLine();
      if (placa != null)
      {
        carros.Add(placa);
        Console.WriteLine("Carro estacionado com sucesso!");
      }
      else
      {
        Console.WriteLine("Placa inválida!");
      }
      Console.WriteLine("pressione qualquer tecla para continuar");
      Console.ReadLine();
      Console.Clear();
      break;
    case 2:
      Console.WriteLine("========Veículos========");
      int contador = 0;

      foreach (var carro in carros)
      {
        Console.WriteLine($"[{contador}] {carro}");
        contador++;
      }

      Console.WriteLine("========Veículos========");
      Console.Write("Deseja remover qual veiculo? ");
      Console.Write("Opção:");
      var opcaoPlaca = Convert.ToInt32(Console.ReadLine());
      carros.RemoveAt(opcaoPlaca);
      Console.WriteLine("Carro removido com sucesso!");
      Console.WriteLine("pressione qualquer tecla para continuar");
      Console.ReadLine();
      Console.Clear();
      break;
    case 3:
      Console.WriteLine("========Veículos========");
      foreach (var carro in carros)
      {
        Console.WriteLine($"{carro}");
      }
      Console.WriteLine("========Veículos========");
      Console.WriteLine("pressione qualquer tecla para continuar");
      Console.ReadLine();
      Console.Clear();
      break;
  }

  if (opcao == 4)
  {
    break;
  }
}
CalcularTarifa.Tarifa(pInicial:precoInicial, tarifa:precoPorHora);