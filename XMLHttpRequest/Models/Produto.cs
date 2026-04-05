namespace XMLHttpRequest.Models;

public class Produto
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEstoque { get; set; }
    public required string Categoria { get; set; }
    public required string ImagemUrl { get; set; }
}
