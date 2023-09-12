using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        //Per i dvd si ha in aggiunta la durata.

        //ATTRIBUTI
        public int Length { get; set; }

        //COSTRUTTORE
        public Dvd(string title, int year, string sector, int shelf, string authorFirstName, string authorLastName, int length) : base(title, year, sector, shelf, authorFirstName, authorLastName )
        {
            this.Length = length;
        }

        //METODI
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"\tDurata: {this.Length} minuti");
        }
    }
}

