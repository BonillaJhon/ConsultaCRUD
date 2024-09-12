using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ConsultaCRUD.Models
{
    [Table("Usuario")]
    public class Usuarios
    {
        [Key]
        public int Identificador { get; set; }

        [Required]
        [MaxLength(100)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string Pass { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public int PersonaId { get; set; }

        // Evitar referencia cíclica en la serialización
        [JsonIgnore]
        public Persona? Persona { get; set; }
    }
}
