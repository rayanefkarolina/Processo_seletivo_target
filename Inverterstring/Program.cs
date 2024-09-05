using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Informe uma string para ser invertida:");
    string? input = Console.ReadLine();

    if (input == null)
    {
      Console.WriteLine("Entrada inválida. Nenhuma string fornecida.");
    }
    else
    {
      string reversed = ReverseString(input);
      Console.WriteLine("String invertida: " + reversed);
    }
  }

  static string ReverseString(string str)
  {

    if (str == null)
    {
      throw new ArgumentNullException(nameof(str), "O argumento não pode ser nulo.");
    }

    char[] charArray = new char[str.Length];
    int end = str.Length - 1;


    for (int i = 0; i < str.Length; i++)
    {
      charArray[i] = str[end - i];
    }

    return new string(charArray);
  }
}
