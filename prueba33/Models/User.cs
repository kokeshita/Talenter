using System;
namespace prueba33.Models
{
    public abstract class User
    {
        public int Id { get; private set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public string Email { get; set; }
    }
}
