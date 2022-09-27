namespace EstruturaCondicionalIfElse;

class NegativeNumber {
  static void Main() {
    int number;

    Console.Write("Digite um número: ");
    number = int.Parse(Console.ReadLine());

    if (number < 0 ) {
      Console.WriteLine("NEGATIVO");
    } else {
      Console.WriteLine("NÃO NEGATIVO");
    }
    
  }
}