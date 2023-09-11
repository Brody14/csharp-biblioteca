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
        public List<Document> Documents = new List<Document>();
        public List<User> Users = new List<User>();
        public List<Loan> Loans = new List<Loan>();

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
    }

    
}
