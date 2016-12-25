using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtest.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsVisible { get; set; }

        public DateTime? Birthdate { get; set; }
        //inget mer gjort. 
    }
}