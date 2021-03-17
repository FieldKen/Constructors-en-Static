using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Fiets f1 = new Fiets();
            Fiets f2 = new Fiets();
            Fiets f3 = new Fiets();
            Fiets.VerminderFiets();
            Fiets.VerminderFiets();
            Fiets f4 = new Fiets();
            Fiets.GeefAantal();


            Console.ReadLine();

            Student student = new Student("Ken", "Field", "Stationstraat 13");
            Student student2 = new Student("Bart", "Scheyltjens");
            Student student3 = new Student() { Voornaam = "Vincent", Achternaam = "Callaerts", Adres = "Parkstraat 1" };

            Console.WriteLine(MijnLibrary.Optellen(5,7));

            Console.WriteLine($"{student.Voornaam} {student.Achternaam} woont in {student.Adres}.");
            Console.WriteLine($"{student2.Voornaam} {student2.Achternaam} woont in {student2.Adres}.");
            Console.WriteLine($"{student3.Voornaam} {student3.Achternaam} woont in {student3.Adres}.");
            Console.ReadLine();
        }

    }
}
