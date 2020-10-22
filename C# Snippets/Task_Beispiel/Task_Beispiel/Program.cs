using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Beispiel {
    class Program {
        static void Main(string[] args) {
            Task task1 = new Task(Aufgabe1);
            task1.Start();
            Task task2 = Task.Factory.StartNew(Aufgabe2);
            Task task3 = Task.Factory.StartNew(Aufgabe3);
            Task task4 = Task.Factory.StartNew(Aufgabe4);
            Task task5 = Task.Factory.StartNew(Aufgabe5);



            Console.WriteLine("Main Methode Ende");
            Console.ReadKey();
        }

        static void Aufgabe1() {
            for (int i = 0; i < 1000; i++) {
                Thread.Sleep(1000);
                Console.WriteLine("Aufgabe 1");
            }
        }

        static void Aufgabe2() {
            for (int i = 0; i < 1000; i++) {
                Thread.Sleep(1000);
                Console.WriteLine("Aufgabe 2");
            }
        }

        static void Aufgabe3() {
            for (int i = 0; i < 1000; i++) {
                Thread.Sleep(1000);
                Console.WriteLine("Aufgabe 3");
            }
        }

        static void Aufgabe4() {
            for (int i = 0; i < 500; i++) {
                Thread.Sleep(100);
                Console.WriteLine("Aufgabe 4");
                Console.WriteLine("Aufgabe 4 " + i);
            }
        }

        static void Aufgabe5() {
            for (int i = 0; i < 1000; i++) {
                Thread.Sleep(1000);
                Console.WriteLine("Aufgabe 5");
            }
        }
    }
}
