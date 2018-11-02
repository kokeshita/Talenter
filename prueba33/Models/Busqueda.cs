using System;
namespace prueba33.Models
{
    public class Busqueda
    {
        public string Puesto { get; set; } //TODO; Reemplazar por Puesto?
        public float Salario { get; set; }
        public Rubro Rubro { get; set; }
        public Modalidad Modalidad { get; set; } 
        public TipoContrato Contrato { get; set; }
        public Dedicacion Dedicacion { get; set; }
        public string Descripcion { get; set; }

        public Busqueda(string Puesto, Rubro Rubro, TipoContrato Contrato, string Descripcion)
        {
            this.Puesto = Puesto;
            this.Rubro = Rubro;
            this.Contrato = Contrato;
            this.Descripcion = Descripcion;
        }

        public Busqueda(string Puesto, Rubro rubro){
            this.Puesto = Puesto;
            this.Rubro = Rubro;
        }
    }
}
