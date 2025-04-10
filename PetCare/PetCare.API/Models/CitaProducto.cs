using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa la relación entre una cita y un producto utilizado o entregado en ella.
    /// </summary>
    public class CitaProducto
    {
        /// <summary>
        /// Clave primaria de la relación.
        /// </summary>
        [Key]
        public int IdCitaProducto { get; set; }

        /// <summary>
        /// Clave foránea de la cita.
        /// </summary>
        [Required]
        public int IdCita { get; set; }

        /// <summary>
        /// Clave foránea del producto.
        /// </summary>
        [Required]
        public int IdProducto { get; set; }

        /// <summary>
        /// Cantidad del producto utilizada en la cita.
        /// </summary>
        [Required]
        public int Cantidad { get; set; }
    }
}
