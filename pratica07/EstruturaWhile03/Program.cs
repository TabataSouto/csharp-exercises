using System;

namespace EstruturaWhile03;

public class FuelFilled {
  static void Main() {
    int code = int.Parse(Console.ReadLine());
    int alcohol = 0;
    int gasoline = 0;
    int diesel = 0;
    
    while (code != 4) {
      if (code == 1) alcohol++;
      if (code == 2) gasoline++;
      if (code == 3) diesel++;
      else code = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("MUITO OBRIGADO");
    Console.WriteLine($"Alcool: {alcohol}");
    Console.WriteLine($"Gasolina: {gasoline}");
    Console.WriteLine($"Diesel: {diesel}");
  }
}