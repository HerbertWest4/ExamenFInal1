using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendHerbert.Models
{
    public class Hangar
    {
        [Key]
        public int idHangar { get; set; }
        public int capacidad { get; set; }
        public string localizacion { get; set; }
        
    }
}
