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

class ProductValueDifference {
    static void Main() {
        int A, B, C, D, calc;

        Console.Write("Digite o primeiro valor: ");
        A = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        B = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro valor: ");
        C = int.Parse(Console.ReadLine());
        Console.Write("Digite o quarto valor: ");
        D = int.Parse(Console.ReadLine());

        calc = (A * B) - (C * D);

        Console.WriteLine($"DIFERENÇA = {calc}");
    }
}

class EmployeeSalary {
    static void Main() {
        int number, hours;
        double valueHours;

        Console.Write("Digite o número do funcionário: ");
        number = int.Parse(Console.ReadLine());

        Console.Write("Digite as horas trabalhadas: ");
        hours = int.Parse(Console.ReadLine());

        Console.Write("Valor por hora trabalhada: ");
        valueHours = double.Parse(Console.ReadLine());

        double calc = (double)(hours * valueHours);

        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {calc.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}