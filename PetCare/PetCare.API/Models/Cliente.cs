using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa un cliente que posee una o más mascotas.
    /// </summary>
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; } // Clave primaria

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(15)]
        public int Telefono { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
