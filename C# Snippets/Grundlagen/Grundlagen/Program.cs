using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen        // über den namespace kann man es überall einbinden  (System.Consol
{
    class Program
    {
        static void Main(string[] args)     // Einstiegspunkt des Programmes
        {
            // von Grundauf Objektorientiert
            Console.WriteLine("C# ist easy");
            Console.WriteLine("300 + 200");

            byte zahl1;         //  Variablen-Deklaration
            int zahl2 = 500;    //  Variablen-Deklaration mit Initialisierung / Wertzuweisung

            int zahl3, zahl4, zahl5 = 0;    // mehrere Variablen benennen (geht auch ohne wertzuweisung)

            zahl1 = 200;        // Wertzuweisung

            /* Bezeichner dürfen nicht mit einer Zahl beginnen
               Bezeichner nur aus alphanumerischen Zeichen
               keine Sonderzeichen mit der Ausnahme _
            */

            // Wertebereich von Datentypen ermitteln
            Console.WriteLine("kleinster Wert von byte " + byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine("kleinster Wert von byte " + byte.MinValue + " größter Wert von byte " + byte.MaxValue);


            // nur bei zahlenwerte
            zahl2 = zahl1;  // byte in int geht   // implizite Konvertierung    (vom größeren in kleinerem geht immer)

            //zahl2 = 1000;       // vorsicht byte hat nur 255 kommt unten falsches Ergebniss raus
            zahl2 = 255;

            //zahl1 = zahl2;  // int geht nicht ins byte
            zahl1 = (byte)zahl2; // explizite Konvertierung

            Console.WriteLine(zahl1);

            double ergebnis = 5 / 2;    // wenn ich zwei ganzwertige Zahlen berechne gibt es nur ganzwertige Ergebniss
            Console.WriteLine(ergebnis);

            double ergebnis1 = 5.0 / 2.0; // .0 für Kommastellen
            Console.WriteLine(ergebnis1);

            // string to int
            string st = "123";
            int value = Convert.ToInt32(st);    // den string (muß aus zahlen bestehen) nach int konvertieren um damit rechnen zu können
            Console.WriteLine( value + 200);

            // int to string
            st = Convert.ToString( value );
            st = value + "";
            st = value.ToString();

            // ----------------------------------------------------------------------------------------------
            // 10 = 00001010
            // 0000010100 = 20
            // 00000000 = 0
            // 11111111 = -1
            // -128 64 32 16 8 4 2 1
            unchecked
            {
                //byte test = (byte)(255 + 2);
                sbyte test2 = (sbyte)(127 + 1);
                Console.WriteLine(test2);
            }
            Console.WriteLine(short.MinValue);

            // operatoren
            // Inkrement / Dekrement
            value = 10;

            Console.WriteLine(value++ + 100);
            Console.WriteLine(value);

        }
    }
}
