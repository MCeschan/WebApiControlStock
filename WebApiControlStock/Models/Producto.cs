using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiControlStock.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }


        [Required]
        [Column(TypeName ="char(1)")]
        public string LineaProducto { get; set; }


        [Column(TypeName ="money")]
        public int Precio { get;}

        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaId")]

        public Categoria categoria { get; set; }
    }
}
