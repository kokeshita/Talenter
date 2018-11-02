using System;
namespace prueba33.Models
{
    public class CurriculumVitae
    {
        public string Estudios { get; set; } //TODO: En un futuro cambiar por una list de Estudio, ya que alguien puede tener muchos estudios
        public string Experiencia { get; set; } //TODO: Lo mismo que estudios, pero con Experiencia
        public string Objetivo { get; set; } //TODO: Lo mismo
        public float Remuneracion { get; set; }

        public CurriculumVitae()
        {
        }
    }
}
