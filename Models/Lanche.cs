using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesApp.Models
{
    public class Lanche
    {
        public int LanchesId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        //ForeignKey - relacionamento entre as Classes 'Lanche' e 'Categoria' (um Lanche pode ter muitas Categorias)
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
