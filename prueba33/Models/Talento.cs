using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Talento : User
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public List<string> Rubros { get; set; } //TODO: Cambiar string por Rubro
        public CurriculumVitae Curriculum { get; set; }

        public Talento()
        {
        }
    }
}
