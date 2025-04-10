using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa un proveedor de productos o servicios para la veterinaria.
    /// </summary>
    public class Proveedor
    {
        /// <summary>
        /// Clave primaria del proveedor.
        /// </summary>
        [Key]
        public int IdProveedor { get; set; }

        /// <summary>
        /// Nombre del proveedor.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        /// <summary>
        /// Correo electrónico del proveedor.
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        /// <summary>
        /// Teléfono del proveedor.
        /// </summary>
        [Required]
        [MaxLength(15)]
        public int Telefono { get; set; }
    }
}
