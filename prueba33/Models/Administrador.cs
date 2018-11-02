using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Administrador : Empleado
    {
        public string RazonSocial { get; set; }
        public List<Empleado> Empleados { get; set; }
        
        public Administrador()
        {
        }
    }
}
