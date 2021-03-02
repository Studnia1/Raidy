using System;

namespace API.Model
{
    public class User
    {
        public int Id {get; set;}
        public string Login {get; set;}
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
    }
}