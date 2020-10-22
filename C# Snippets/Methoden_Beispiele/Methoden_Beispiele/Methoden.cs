using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden_Beispiele {
    class Methoden {
        // Syntax
        // [Zugriffsmodifizierer] Typ(vom Rückgabewert) Bezeichner([Parameterliste]){} 

        // Zugriffsmodifizierer
        // private - Zugriff nur in der Klasse wo es deklariert wird / von anderen Klassen nicht sichtbar
        // public - keine Zugriffseinschränkung / von überall zugreifbar
        // protected - wie private, aber auch in abgeleiteten Klassen zugreifbar
        // internal - Zugriff von allen Klassen der gleichen Assembly/Projekt
        // protected internal - Kombination aus beiden

        // Methode mit Rückgabewert und Parameter als Referenz
        public int Methode1(ref int i) {
            i++;
            return i;
        }

        // überladene Methoden, gleichnamige Methoden die sich in der Anzahl/Datentyp der Parameterliste unterscheiden
        public int Methode1(int x) {
            Console.WriteLine("Methode A");
            return 0;
        }

        public int Methode1(byte x) {
            Console.WriteLine("Methode B");
            return 0;
        }

        // Methoden mit Params
        public void Methode2(string st, params int[] zahlen) {
            foreach (int item in zahlen) {
                Console.WriteLine(item);
            }
        }

        // Methode mit optionalen Parametern (Default-Werte)
        public void Methode3(int x, int y = 10, int z = 20) {
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
        }




    }
}
