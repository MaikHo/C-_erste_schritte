using System;


namespace ConsoleApplication301
{
    class Program
    {
        static void Main(string[] args)
        {

            string var1;                // Name des Kunden
            int var2;                   // Anzahl der Flaschen in Stck.
            double var3;                // Einzelpreis Flasche
            double var4;                // Gesamtpreis
            double var5;                // Zufuhrkosten
            double var6;                // Endpreis
                    

            // *********************************************** Eingabe *****************************************

            Console.WriteLine("Name des Kunden: ");

            var1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Anz. d. Flaschen: ");

            var2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Einzelpreis pro Flasche: ");

            var3 = Convert.ToDouble(Console.ReadLine());

            // ****************************************** Verarbeitung und Bedingungen **********************************




            var4 = var2 * var3;                                         // Errechnung Gesamtpreis

            if (var2 < 12)                                              // Zweiseitige Abfrage
            {
                                             
                var5 = 5.00;
            }
            else
            {
                
                var5 = 0;
            }

            var6 = var4 + var5;

            


            // ************************************************* Ausgabe *************************************************

            Console.Clear();

            Console.WriteLine("Kundenname: " + var1);
            Console.WriteLine();
            Console.WriteLine("Anzahl der Flaschen        : {0:0000}" ,var2);
            Console.WriteLine();
            Console.WriteLine("Einzelpreis pro Flasche    : {0:00000.00}", var3);
            Console.WriteLine();
            Console.WriteLine("Gesamtpreis                : {0:00000.00}" , var4);
            Console.WriteLine();
            Console.WriteLine("Zufuhrkosten               : {0:00000.00}" , var5);
            Console.WriteLine("========================================");
            Console.WriteLine("Endpreis                   : {0:00000.00}" , var6);
            
            Console.ReadKey();

        }
    }
}
