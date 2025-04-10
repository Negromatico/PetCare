using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa una cita en el sistema de PetCare.
    /// </summary>
    public class Cita
    {
        [Key]
        public int IdCita { get; set; } // Clave primaria

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [MaxLength(200)]
        public string Motivo { get; set; }

        [Required]
        public int IdMascota { get; set; }
    }
}
