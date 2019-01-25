using System;
using System.IO;
using System.Globalization;

namespace debugws2
{
  class Program
  {
    private long sum()
    {
      string[] data = File.ReadAllLines("data");
      long total = 0;

      for (int x = 0; x < data.Length; x++)
      {

        total += cnv(data[x]);
      }

      return total;
    }

    private int cnv(string val)
    {

      string val2 = val;
      if( val.Contains('G')){
          val2 = val.Replace('G','E');
      }

      Int32.TryParse(val2, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int value);

      return value;
    }

    static void Main(string[] args)
    {
      var p = new Program();
      Console.WriteLine("Total: {0}", p.sum());
    }
  }
}