using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        /*Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo(libri, DVD).
            I documenti sono caratterizzati da:
            un codice identificativo di tipo stringa
            titolo
            anno
            settore(storia, matematica, economia, …)
            uno scaffale in cui è posizionato
            un autore(Nome, Cognome)*/

        //ATTRIBUTI
        public string Code { get; private set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string  Sector { get; set; }
        public int Shelf { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }



        //COSTRUTTORE

        public Document(string title, int year, string sector, int shelf, string authorFirstName, string authorLastName)
        {
            this.Code = title + year;
            this.Title = title;
            this.Year = year;
            this.Sector = sector;
            this.Shelf = shelf;
            this.AuthorFirstName = authorFirstName;
            this.AuthorLastName = authorLastName;
        }

        //METODI
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Dettagli documento:\n\tCodice: {this.Code}\n\tTitolo: {this.Title}\n\tAnno di produzione: {this.Year}\n\tSettore: {this.Sector}\n\tScaffale: {this.Shelf}\n\tAutore: {this.AuthorFirstName} {this.AuthorLastName}");
        }
    }
}
