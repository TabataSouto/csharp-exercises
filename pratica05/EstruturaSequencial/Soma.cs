namespace EstruturaSequencial;

class DataInputAndOutput {
  static void Main() {
    int numberOne, numberTwo, sum;

    numberOne = int.Parse(Console.ReadLine());
    numberTwo = int.Parse(Console.ReadLine());

    sum = numberOne + numberTwo;

    Console.WriteLine($"SOMA = {sum}");
  }
};