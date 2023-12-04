using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendHerbert.Models
{
    public class Piloto
    {
        [Key]
        public int numeroLicencia { get; set; }
        public string restricciones { get; set; }
        public int salario { get; set; }
        public string turno { get; set; }
        
    }
}
