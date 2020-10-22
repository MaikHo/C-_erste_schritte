using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateien {
    class Program {
        
        static void Main(string[] args) {
            //DateiSchreiben();
            //DateiLesen();
            //DateiZeilenweiseLesen();

            //DateiBinaer();
            DateiBinaerLesen();

        }

        static void DateiBinaerLesen() {
            FileStream fs = new FileStream("daten.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();
        }

        static void DateiBinaer() {
            int zahl = 100;
            double d = 123.99;
            FileStream fs = new FileStream("daten.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(zahl);
            bw.Write(d);
            bw.Close();
        }

        static void DateiZeilenweiseLesen() {
            StreamReader sr = new StreamReader(@"test.txt");
            string zeile;
            while ((zeile = sr.ReadLine()) != null) {
                Console.WriteLine(zeile);
            }
            sr.Close();
        }

        static void DateiLesen() {
            StreamReader sr = new StreamReader(@"test.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        static void DateiSchreiben() {
            FileStream fs = new FileStream(@"test.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Csharp ist easy");
            sw.Flush();
            sw.Close();
        }
    }
}
