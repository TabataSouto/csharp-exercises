namespace EstruturaSequencial02;
using System.Globalization;

class CircleCalc {
    static void Main() {
      // calculo: (area * tt) * 2
      double area = 0;
      double tt = 3.14159;

      Console.Write("Digite um número: ");
      area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double calc = (area * tt) * area;

      Console.WriteLine($"A = {calc.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}