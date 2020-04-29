using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
 
            String str = "nichts sagend";
            Console.WriteLine(str);
            Console.WriteLine("Zeichenkette " + str);
            Console.WriteLine("Zeichenkette {0}", str);
            Console.WriteLine("Zeichenkette {0,10}", str);
            Console.WriteLine($"Zeichenkette {str,10}");

            int iWert = 123456;
            //iWert = Int32.Parse(Console.ReadLine());
            //Int32.TryParse(Console.ReadLine(),out iWert);

            Console.WriteLine("Int Wert "+iWert);
            Console.WriteLine("Int Wert {0}",iWert);
            Console.WriteLine("Int Wert {0,10}",iWert);
            Console.WriteLine($"Int Wert {iWert,10}");

            double  douWert = 1.23456789;
            // Ausgabe allgemein: {PlatzhalterID[,Breite][:Format[Stellen]]} , z. B. {0,10:F2}
            // Formate:
            // d: dezimal (default)
            // e: wissenschaftlich
            // f: fixed-point
            // g: generisch
            // n: Kommata
            // x: hex

            Console.WriteLine("Double Wert {0,10:F2}", douWert); //mit ,
            Console.WriteLine("Double Wert {0,10}", douWert.ToString("F2",CultureInfo.InvariantCulture)); //mit .

        }
    }

