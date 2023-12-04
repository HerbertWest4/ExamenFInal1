using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendHerbert.Models
{
    public class Avion
    {

        [Key]
        public int idAvion { get; set; }
        public string modelo { get; set; }
        public int peso { get; set; }
        public int capacidad { get; set; }




    }
}
