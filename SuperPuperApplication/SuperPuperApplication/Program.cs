using System;

namespace SuperPuperApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var batya = new Manager("Batya");
            var natalka = new Tester("Natalka");
            var dima = new Tester("Dima");
            var vasiliy = new Tester("Vasiliy");
            var nazar = new Developer("Nazar");
            var oleh = new Developer("Oleh");
            var andriy = new Developer("Andriy");

            Console.WriteLine("New day has started at company:");
            Employee.DisplayCompanyInfo();
            Console.WriteLine("");
            andriy.Introduce();
            oleh.Introduce();
            andriy.Work();
            oleh.Work();
            natalka.Introduce();
            natalka.Work();
            nazar.Introduce();
            vasiliy.Introduce();
            dima.Introduce();
            nazar.Work();
            vasiliy.Work();
            dima.Work();
            batya.Introduce();
            batya.Work();
        }
    }
}
