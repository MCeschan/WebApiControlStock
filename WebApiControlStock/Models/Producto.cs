using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiControlStock.Validations;

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
        [SoloHSAtributte]
        public string LineaProducto { get; set; }

        [PrecioMayorAtributte]
        [Column(TypeName ="money")]
        public int Precio { get;}

        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]

        public Categoria Categoria { get; set; }
    }
}
