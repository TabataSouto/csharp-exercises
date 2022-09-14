using System;

namespace WorkTools;

public static class NumbersTools {
  static void Main() {
      static int CountOf(int[] numbers, int value) {
      var count = 0;

      foreach(var number in numbers) {
        if (number == value) count++;
      }
      return count;
    }
  }
}