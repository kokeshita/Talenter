using System;
namespace prueba33.Models
{
    public class Busqueda
    {
        public string Puesto { get; set; } //TODO; Reemplazar por Puesto
        public float Salario { get; set; }
        public string Rubro { get; set; } //TODO: Cambiar por Rubro
        public string Modalidad { get; set; } //TODO: Cambiar por Enum Modalidad
        public string Contrato { get; set; } //TODO: Cambio Enum TipoContrato
        public string Dedicacion { get; set; } //TODO; Cambiar Enum Dedicacion
        public string Descripcion { get; set; }

        public Busqueda()
        {
        }
    }
}
