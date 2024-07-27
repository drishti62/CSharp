using System;

public class CharStructureSample
{
    public static void Main()
    {
        char chA = 'A';
        char ch1 = '1';
        string str = "test string";

        Console.WriteLine(chA.CompareTo('B'));          //-----------  Output: "-1" (meaning 'A' is 1 less than 'B')
        Console.WriteLine(chA.Equals('A'));             //-----------  Output: "True"
        Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  Output: "1"
        Console.WriteLine(Char.IsControl('\t'));        //-----------  Output: "True"
        Console.WriteLine(Char.IsDigit(ch1));           //-----------  Output: "True"
        Console.WriteLine(Char.IsLetter(','));          //-----------  Output: "False"
        Console.WriteLine(Char.IsLower('u'));           //-----------  Output: "True"
        Console.WriteLine(Char.IsNumber(ch1));          //-----------  Output: "True"
        Console.WriteLine(Char.IsPunctuation('.'));     //-----------  Output: "True"
        Console.WriteLine(Char.IsSeparator(str, 4));    //-----------  Output: "True"
        Console.WriteLine(Char.IsSymbol('+'));          //-----------  Output: "True"
        Console.WriteLine(Char.IsWhiteSpace(str, 4));   //-----------  Output: "True"
        Console.WriteLine(Char.Parse("S"));             //-----------  Output: "S"
        Console.WriteLine(Char.ToLower('M'));           //-----------  Output: "m"
        Console.WriteLine('x'.ToString());              //-----------  Output: "x"
    }
}




using System;

public class Example
{
   public static void Main()
   {
      decimal[] values = {12.6m, 12.1m, 9.5m, 8.16m, .1m, -.1m,  -1.1m,
                          -1.9m, -3.9m};
      Console.WriteLine("{0,-8} {1,10} {2,10}\n",
                        "Value", "Ceiling", "Floor");
      foreach (decimal value in values)
      Console.WriteLine("{0,-8} {1,10} {2,10}", value,
                        Decimal.Ceiling(value), Decimal.Floor(value));
   }
}
// The example displays the following output:
//       Value       Ceiling      Floor
//
//       12.6             13         12
//       12.1             13         12
//       9.5              10          9
//       8.16              9          8
//       0.1               1          0
//       -0.1              0         -1
//       -1.1             -1         -2
//       -1.9             -1         -2
//       -3.9             -3         -4
all data types in c # and replace min value max value specified weteher it is signed or unsigned

