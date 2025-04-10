using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa una mascota registrada por un cliente.
    /// </summary>
    public class Mascota
    {
        [Key]
        public int IdMascota { get; set; } // Clave primaria

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Especie { get; set; }

        [Required]
        [MaxLength(50)]
        public string Raza { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        public int IdCliente { get; set; } // Clave foránea
    }
}
