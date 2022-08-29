using System;

namespace EstruturaWhile {
  public class AllowedAccess {
  static void Main() {
// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
   Console.Write("Digite a senha: ");
   int password = Convert.ToInt32(Console.ReadLine());

  while (password != 2002) {
    Console.WriteLine("Senha Invalida");
    password = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Acesso Permitido");
  }
}
}