namespace LanchesApp.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //ForeignKey - relacionamento entre as Classes 'Lanche' e 'Categoria' (um Lanche pode ter muitas Categorias)
        public List<Lanche> Lanches { get; set; }
    }
}
