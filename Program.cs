using System;

namespace C_
{
  class Program
  {
    static void Main(string[] args)
    {
      decimal km, lts, media = 5.22m;

      Console.WriteLine("Informa a distância percorrida: ");
      decimal.TryParse(Console.ReadLine(), out km);

      Console.WriteLine("Informe a quantidade de gasolina gasta: ");
      decimal.TryParse(Console.ReadLine(), out lts);
      media = km / lts;

      Console.WriteLine($"Média de litros por km: {media.ToString("0.##")}");


      Console.ReadLine();
    }
  }
}