using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Empleado
    {
        public int RolId { get; set; }
        public List<Busqueda> Busquedas { get; set; } //TODO: Reemplazar string por Busqueda

        public Empleado()
        {
        }
    }
}
