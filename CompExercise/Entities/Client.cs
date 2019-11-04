using System;
using System.Collections.Generic;
using System.Text;

namespace CompExercise.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birhtDate)
        {
            Name = name;
            Email = email;
            BirthDate = birhtDate;
        }


        public override string ToString()
        {
            return Name 
                + ", (" 
                + BirthDate.ToString("dd/MM/yyyy") 
                + ") - "
                + Email;
        }


    }
}
