using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }
      

        //COSTRUTTORE

        public Loan(DateTime startDate, DateTime endDate, User user, Document document)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.User = user;
            this.Document = document;
        }
    }
}
