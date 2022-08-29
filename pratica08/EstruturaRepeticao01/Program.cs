using System;
namespace EstruturaRepeticao01;

class Program {
  static void Main() {
    Console.Write("Quantos números inteiros você vai digitar? ");

    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= number; i++) {
      Console.Write("Valor: #{0}:", i);
      int value = Convert.ToInt32(Console.ReadLine());
      sum += value;
    }

    Console.WriteLine($"Soma = {sum}");
  }
}