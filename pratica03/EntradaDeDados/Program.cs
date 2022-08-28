using System;
using System.Globalization;

namespace EntradaDeDados {
  class InfosPerson {
    static void Main() {

      // Como o console com a pergunta/pedido não seja informado antes da declaração do ReadLine
      // ele fará a "impressão" na tela junto com o nome, apenas depois de informar o nome.
      Console.WriteLine("Entre com seu nome completo:");
      string fullName = Console.ReadLine();

      Console.WriteLine("Quantos quartos tem na sua casa?");
      int bedrooms = int.Parse(Console.ReadLine());

      Console.WriteLine("Entre com o preço de um produto:");
      double priceProduct = double.Parse(Console.ReadLine());

      Console.WriteLine("Entre com seu último nome, idade e altura:");
      string[] vet = Console.ReadLine().Split(' ');
      string lastName = vet[0];
      int age = int.Parse(vet[1]);
      double height = double.Parse(vet[2]);


      Console.WriteLine(fullName);
      Console.WriteLine(bedrooms);
      Console.WriteLine(priceProduct.ToString("F2"));
      Console.WriteLine(lastName);
      Console.WriteLine(age);
      Console.WriteLine(height.ToString("F2"));
    }
  }
}