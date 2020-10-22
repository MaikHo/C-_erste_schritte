using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleFunktionen {
    class Program {
        static void Main(string[] args) {
            // Zeichenkettenfunktionen
            string zeichenkette = "Csharp ist einfach";

            Console.WriteLine( zeichenkette.Substring(1, 2) );
            Console.WriteLine( zeichenkette.IndexOf("a") );
            Console.WriteLine( zeichenkette.Replace("Csharp", "PHP") );
            Console.WriteLine( zeichenkette.Remove(5) );
            


            // Mathematische Funktionen
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine( Math.PI );
            Console.WriteLine( Math.Round( 123.98765, 2 ) );
            Console.WriteLine( Math.Floor(123.98765) );
            Console.WriteLine(Math.Ceiling(123.98765));


            // Zufallszahlen
            Random zufall = new Random();
            Console.WriteLine(zufall.Next(1, 7)); // liefert Zufallszahl von einschl. 1 bis einschl. 6
            int z1 = 0, z2 = 0, z3 = 0, z4 = 0, z5 = 0, z6 = 0;
            for (int i = 0; i < 100000; i++) {
                switch (zufall.Next(1, 7)) {
                    case 1:
                        z1++;
                        break;
                    case 2:
                        z2++;
                        break;
                    case 3:
                        z3++;
                        break;
                    case 4:
                        z4++;
                        break;
                    case 5:
                        z5++;
                        break;
                    case 6:
                        z6++;
                        break;
                }
            }
            Console.WriteLine("Zahl 1: " + z1);
            Console.WriteLine("Zahl 2: " + z2);
            Console.WriteLine("Zahl 3: " + z3);
            Console.WriteLine("Zahl 4: " + z4);
            Console.WriteLine("Zahl 5: " + z5);
            Console.WriteLine("Zahl 6: " + z6);


            // TicTacToe
            // 1 2 3
            // 4 5 6
            // 7 8 9
            bool ende = false;
            byte runde = 0;
            do {
                runde++; // Runden zählen

                // bereits gesetzte Felder mit X oder O ausgeben
                for (int i = 1; i < 10; i++) {
                    Console.Write(i + " ");
                    if (i % 3 == 0)
                        Console.WriteLine();
                }

                // Bei Spieler 1 - X / Spieler 2 - O
                byte eingabe = Convert.ToByte(Console.ReadLine());




                // Gewinn prüfen
                // bei Gewinn Spielende Variable ende auf true setzen


            } while ( !ende );


        }
    }
}
