using System;

namespace Products;

class Progam {
  static void Main() {
    string produto1 = "Computador";
    string produto2 = "Mesa de escritório";

    byte idade = 30;
    int codigo = 5290;
    char genero = 'M';

    double preco1 = 2100.0;
    double preco2 = 650.50;
    double medida = 53.234567;

    Console.WriteLine("Produtos:");
    Console.WriteLine($"{produto1}, cujo preço é de R$ {preco1:F2}");
    Console.WriteLine($"{produto2}, cujo preço é de R$ {preco2:F2}");
    Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
    Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
    Console.WriteLine($"Arredondamento (três casas decimais): {medida:F3}");
    Console.WriteLine($"Separador decimal: {medida:F3}");
  }
}