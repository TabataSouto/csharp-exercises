using System;

namespace EstruturaRepeticao03;

public class Program {
  static void Main() {
    /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
      Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
      essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). */

    int value = Convert.ToInt32(Console.ReadLine());
    int inQtde = 0;
    int outQtde = 0;

    for (int i = 0; i < value; i++) {
      int number = Convert.ToInt32(Console.ReadLine());
      if (number >= 10 && number <= 20) {
        inQtde++;
      } else {
        outQtde++;
      }
    }

    Console.WriteLine($"{inQtde} in");
    Console.WriteLine($"{outQtde} in");
  }
}