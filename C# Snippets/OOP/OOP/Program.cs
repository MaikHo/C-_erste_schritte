using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {
    class Program {
        static void Main(string[] args) {
            // Klasseninstanz/Objekt erzeugen
            Mitarbeiter ma1;
            ma1 = new Mitarbeiter();

            Mitarbeiter ma2 = new Mitarbeiter();

            // Zugriff auf Eigenschaften über das Objekt
            ma1.vorname = "Max";
            ma1.nachname = "Mustermann";
            ma1.SetPersonalnummer( 1 );
            ma1.gehalt = 2000;
            
            
            ma2.vorname = "Maxi";
            ma2.nachname = "Musterfrau";
            ma2.SetPersonalnummer( 2 );
            ma2.gehalt = 1000;

            
            Console.WriteLine(ma1.GetPersonalnummer() + " " + ma1.nachname);
            Console.WriteLine(ma2.GetPersonalnummer() + " " + ma2.nachname);

            ma1.MacheUrlaub(5);
            Console.WriteLine(ma1.urlaubstage);

            // Mitarbeiterdaten über Konstruktor zuweisen
            Mitarbeiter ma3 = new Mitarbeiter("Hans", "Dampf", 3, 900);
            Console.WriteLine(ma3.nachname);
            



            ArrayList mitarbeiterliste = new ArrayList();
            mitarbeiterliste.Add(ma1);
            mitarbeiterliste.Add(ma2);

            Mitarbeiter mitarbeiter = (Mitarbeiter)mitarbeiterliste[0];
            Console.WriteLine(mitarbeiter.nachname);

            // typisierte Liste
            List<Mitarbeiter> mitarbeiterliste2 = new List<Mitarbeiter>();
            mitarbeiterliste2.Add(ma1);
            mitarbeiterliste2.Add(ma2);


            Console.WriteLine(mitarbeiterliste2[0].nachname);

            foreach (Mitarbeiter item in mitarbeiterliste2) {
                Console.WriteLine(item.nachname + " " + item.vorname + " " + item.gehalt);
            }

            foreach (object item in mitarbeiterliste) {
                Console.WriteLine( ((Mitarbeiter)item).nachname );
            }

            // Listen Eigenschaften und Methoden
            Console.WriteLine("Anzahl der Elemente in den Listen");
            Console.WriteLine( mitarbeiterliste.Count );
            Console.WriteLine(mitarbeiterliste2.Count() );
            Console.WriteLine("Kapazitaet der Listen");
            Console.WriteLine(mitarbeiterliste.Capacity);
            Console.WriteLine(mitarbeiterliste2.Capacity);



        }
    }
}
