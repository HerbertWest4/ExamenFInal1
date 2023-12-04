using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendHerbert.Models
{
    public class Relacion
    {
        [Key]
        public string nombre { get; set; }
        public int idAvion { get; set; }
        public int numeroLicencia { get; set; }
        public int idHangar { get; set; }
        

    }
}
