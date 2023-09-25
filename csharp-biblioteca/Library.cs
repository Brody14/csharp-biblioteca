using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public List<Document> Documents { get; set; }
        public List<User> Users { get; set; }
        public List<Loan> Loans { get; set; }

        //COSTRUTTORE
        public Library() 
        {
            Documents = new List<Document>();
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        //METODI
        public void AddDocument(Document document)
        {
            Documents.Add(document);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }

        public Document SearchCode(string code)
        {
            return Documents.Find(doc => doc.Code == code);
             
        }

        public Document SearchTitle(string title)
        {
            return Documents.Find(doc => doc.Title == title);
           
        }

        //registrare un prestito

        public void RegisterNewLoan(User user, Document document, DateTime startDate, DateTime endDate)
        {
            if(!Users.Contains(user))
            {
                Console.WriteLine("Utente non registrato");
            }

            if (!Documents.Contains(document))
            {
                Console.WriteLine("Documento non trovato");
            }

            Loan newLoan = new Loan(startDate, endDate, user, document);
            Loans.Add(newLoan);
        }

        //ricerca utente

        public List<Loan> SearchLoanFromUser(string firstName, string lastName)
        {
            return Loans.FindAll(loan => loan.User.FirstName == firstName && loan.User.LastName == lastName);
        }
    }

    
}
