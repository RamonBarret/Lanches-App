using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesApp.Migrations
{
    public partial class PopulateLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageThumbnailUrl,ImageUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo, alface, tomate e batata palha','Delicioso pão de hambúrger com um blend de carne, ovo, presunto, alface, tomate e queijo de primeira qualidade acompanhado de batata palha',1,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',0,'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageThumbnailUrl,ImageUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, presunto, ovo, queijo e tomate','Delicioso pão francês com presunto, ovo, tomate e queijo de primeira qualidade',1,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0,'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageThumbnailUrl,ImageUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, queijo e bacon','Delicioso pão de hambúrger com um blend de carne, bacon e queijo de primeira qualidade',1,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',0,'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImageThumbnailUrl,ImageUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pão integral, queijo branco, peito de peru, cenoura, alface e requeijão','Delicioso pão integral multi grãos com queijo branco, peito de peru, cenoura, alface americana e requeijão cremoso',1,'http://www.macoratti.net/Imagens/lanches/lanchenatura1.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatura1.jpg',1,'Lanche Natural Peito de Peru', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
