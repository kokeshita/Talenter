using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Talento : User
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public List<Rubro> Rubros { get; set; } 
        public List<Busqueda> Aplicaciones { get; set; }
        public CurriculumVitae Curriculum { get; set; }

        public Talento(string Username, string Password, string Email, DateTime Nacimiento)
            :base(Username, Password, Email)
        {
            this.Nacimiento = Nacimiento;
            Aplicaciones = new List<Busqueda>();
        }

        public override void CompletarPerfil(){

        }

        public void AplicarBusqueda(string Puesto, Rubro Rubro){
            Aplicaciones.Add(new Busqueda(Puesto, Rubro));
        }
    }
}
