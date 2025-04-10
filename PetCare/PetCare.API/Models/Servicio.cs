using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa un servicio veterinario disponible en la clínica.
    /// </summary>
    public class Servicio
    {
        /// <summary>
        /// Clave primaria del servicio.
        /// </summary>
        [Key]
        public int IdServicio { get; set; }

        /// <summary>
        /// Nombre del servicio (consulta, vacunación, cirugía, etc.).
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        /// <summary>
        /// Precio del servicio.
        /// </summary>
        [Required]
        public float Precio { get; set; }
    }
}
