using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    /// <summary>
    /// Representa un producto disponible en la veterinaria.
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Clave primaria del producto.
        /// </summary>
        [Key]
        public int IdProducto { get; set; }

        /// <summary>
        /// Nombre del producto.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción del producto.
        /// </summary>
        [MaxLength(300)]
        public string Descripcion { get; set; }

        /// <summary>
        /// Precio del producto.
        /// </summary>
        [Required]
        public float Precio { get; set; }

        /// <summary>
        /// Stock disponible del producto.
        /// </summary>
        [Required]
        public int Stock { get; set; }

        /// <summary>
        /// Clave foránea del proveedor.
        /// </summary>
        [Required]
        public int IdProveedor { get; set; }
    }
}
