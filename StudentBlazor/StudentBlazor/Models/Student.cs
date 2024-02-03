using System;

namespace StudentBlazor.Models
{
    public class Student
    {
        public Uri Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string Studies { get; set; }
    }
}
