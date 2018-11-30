using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assesment6.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, string email,bool attending, string dateAttending)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Attending = attending;
            DateAttending = dateAttending;
            Guest = null;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Attending { get; set; }
        public string DateAttending { get; set; }
        public string Guest { get; set; }
       


    }
}