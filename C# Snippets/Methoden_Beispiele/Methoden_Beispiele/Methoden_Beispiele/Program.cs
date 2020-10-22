using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Methoden_Beispiele {
    class Program {
        static void Main(string[] args) {
            Methoden methoden = new Methoden();
            int zahl = 10;
            Console.WriteLine("Methode1 Rückgabewert: " + methoden.Methode1(ref zahl) );
            Console.WriteLine("zahl: " + zahl);

            byte z = 1;
            methoden.Methode1(z);

            methoden.Methode2("test", 1, 3, 23, 12); // Methodenaufruf mit beliebig vielen Argumenten

            methoden.Methode3(1);
            methoden.Methode3(1, 2);
            methoden.Methode3(1, 2, 3);

            methoden.Methode3(z: 200, x: 300, y: 400); // Methodenaufruf mit benannten Argumenten

        }

        static void TestMethode() {
            Console.WriteLine("Testmethode");
        }
    }
}
