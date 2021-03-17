using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Student
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }

        public Student(string voornaam, string achternaam, string adres)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Adres = adres;
        }

        public Student(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Adres = "Unknown";
        }

        public Student()
        {
            Voornaam = "Unknown";
            Achternaam = "Unknown";
            Adres = "Unknown";
        }
    }
}
