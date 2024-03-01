using System.ComponentModel.DataAnnotations;

namespace Exemplo.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        public string Nome { get; set; }


        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
