using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Informe um número:");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int num))
    {
      if (IsFibonacci(num))
      {
        Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
      }
      else
      {
        Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
      }
    }
    else
    {
      Console.WriteLine("Entrada inválida. Por favor, informe um número inteiro.");
    }
  }

  static bool IsFibonacci(int number)
  {
    int a = 0, b = 1, temp = 0;

    if (number == a || number == b) return true;

    while (b < number)
    {
      temp = a + b;
      a = b;
      b = temp;
    }

    return b == number;
  }
}