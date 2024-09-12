using System.ComponentModel.DataAnnotations;

namespace ConsultaCRUD.Models
{
    public class Persona
    {
        [Key]
        public int Identificador { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string NumeroIdentificacion { get; set; }

        [Required]
        public string Email { get; set; }

        public string TipoIdentificacion { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Relación opcional con Usuario
        public Usuarios? Usuarios { get; set; }
    }
}
