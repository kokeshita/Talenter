using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Empresa
    {
        public int RolId { get; set; }
        public List<string> Busquedas { get; set; } //TODO: Reemplazar string por Busqueda

        public Empresa()
        {
        }
    }
}
