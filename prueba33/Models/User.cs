using System;
namespace prueba33.Models
{
    public abstract class User
    {
        public int Id { get; private set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public string Email { get; set; }

        public User(string Username, string Password, string Email) {
            this.Username = Username;
            this.Passwords = Password;
            this.Email = Email;
        }

        public abstract void CompletarPerfil();

        //El ID es AutoIncrement
    }
}
