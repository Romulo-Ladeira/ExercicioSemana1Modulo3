using System.ComponentModel.DataAnnotations;

namespace ExercicioModulo1.Entity
{
    public class Produto
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string nomeProduto { get; set; }
        [Required]
        public double valorProduto { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
        public DateTime dataCompra { get; set; }
    }
}
    