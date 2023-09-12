using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        //Per i libri si ha in aggiunta il numero di pagine

        //ATTRIBUTI
        public int PageNumber { get; set; }

        //COSTRUTTORE
        public Book(string title, int year, string sector, int shelf, string authorFirstName, string authorLastName, int pageNumber) : base(title, year, sector, shelf, authorFirstName, authorLastName)
        {
            this.PageNumber = pageNumber;
        }

        //METODI
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"\tNumero di pagine: {this.PageNumber}");
        }
    }
}

