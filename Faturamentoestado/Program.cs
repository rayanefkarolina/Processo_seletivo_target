using System;
class Program
{
  static void Main(string[] args)
  {
    decimal sp = 67836.43m;
    decimal rj = 36678.66m;
    decimal mg = 29229.88m;
    decimal es = 27165.48m;
    decimal outros = 19849.53m;
    decimal total = sp + rj + mg + es + outros;

    Console.WriteLine("Percentual de SP: " + (sp / total * 100).ToString("F2") + "%");
    Console.WriteLine("Percentual de RJ: " + (rj / total * 100).ToString("F2") + "%");
    Console.WriteLine("Percentual de MG: " + (mg / total * 100).ToString("F2") + "%");
    Console.WriteLine("Percentual de ES: " + (es / total * 100).ToString("F2") + "%");
    Console.WriteLine("Percentual de Outros: " + (outros / total * 100).ToString("F2") + "%");
  }
}
