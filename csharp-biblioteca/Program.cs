namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookA = new("The Mamba mentality", 2018, "Biografie", 4, "Kobe", "Bryant", 210);
            Book bookB = new("AIR. La storia di Michael Jordan", 2020, "Biografie", 4, "David", "Halberstam", 560);
            Dvd dvdA = new("Coach Carter", 2005, "Sportivo", 8, "Thomas", "Carter", 136);
            Dvd dvdB = new("The Last Dance", 2020, "Documentario", 5, "Jason", "Hehir", 500);
            User user1 = new("Avramovic", "Aleksa", "aleksa.avra@gmail.com", "jgigjjdene", 01156785);

            Library library = new Library();
            library.AddDocument(bookA);
            library.AddDocument(bookB);
            library.AddDocument(dvdA);
            library.AddDocument(dvdB);
            library.AddUser(user1);

            //ricerca per codice
            Document searchedCode = library.SearchCode(bookA.Code);
            searchedCode.PrintInfo();

            //ricerca per titolo
            Document searchTitle = library.SearchTitle(dvdA.Title);
            searchTitle.PrintInfo();

            //aggiunta di un prestito

            library.RegisterNewLoan(user1, bookA, DateTime.Now, DateTime.Now.AddDays(8));
            library.RegisterNewLoan(user1, bookB, DateTime.Now, DateTime.Now.AddDays(8));



            List<Loan> loansFound = library.SearchLoanFromUser("Aleksa", "Avramovic");

            if (loansFound.Count > 0)
            {
                foreach(Loan loan in loansFound)
                {
                    Console.WriteLine();
                    Console.WriteLine($"L'utente {loan.User.FirstName} {loan.User.LastName} ha preso in prestito il documento {loan.Document.Title} dal {loan.StartDate} al {loan.EndDate}");
                }
            }
        }
    }
}