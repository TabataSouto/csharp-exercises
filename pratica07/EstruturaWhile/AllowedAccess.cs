using System;

namespace EstruturaWhile;

public class AllowedAccess {
  static void Main() {
   Console.Write("Digite a senha: ");
   int password = Convert.ToInt32(Console.ReadLine());

  while (password != 2002) {
    Console.WriteLine("Senha Invalida");
    password = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Acesso Permitido");
  }
}