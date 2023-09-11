using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        /*Gli utenti si possono registrare al sistema, fornendo:
            cognome
            nome
            email
            password
            recapito telefonico*/

        //ATTRIBUTI
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { private get;  set; }
        public int PhoneNumber { get; set; }

        //COSTRUTTORE

        public User(string lastName, string firstName, string email, string password, int phoneNumber)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }
    }
}
