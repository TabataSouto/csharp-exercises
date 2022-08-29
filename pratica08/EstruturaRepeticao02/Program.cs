using System;

namespace EstruturaRepeticao02;

public class Program {
  static void Main() {
    /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre
    os ímpares de 1 até X, um valor por linha, inclusive o
    X, se for o caso. */

    int value = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= value; i++) {
      if (i % 2 == 1) {
        Console.WriteLine(i);
      }
    }
  }
}