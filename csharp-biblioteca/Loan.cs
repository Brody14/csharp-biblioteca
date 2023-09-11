using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string DocumentCode { get; set; }

        //COSTRUTTORE

        public Loan(string startDate, string endDate, string userFirstName, string userLastName, string documentCode)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.UserFirstName = userFirstName;
            this.UserLastName = userLastName;        
            this.DocumentCode = documentCode;
        }
    }
}
