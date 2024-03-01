using System.ComponentModel.DataAnnotations;

namespace Exemplo.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public int CategoriaId { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        public string Nome { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
