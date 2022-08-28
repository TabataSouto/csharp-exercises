using System;

namespace Course;

class Program {
  static void Main(string[] args) {
    sbyte n1 = 100;
    Console.WriteLine(n1);

    // não aceita valores negativos
    byte n2 = 254;
    // adiciona mais um, onde o valor passa a vale 255
    n2++;
    Console.WriteLine(n2);

    int n3 = 1000;
    Console.WriteLine(n3);
  }
}