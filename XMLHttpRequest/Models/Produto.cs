namespace XMLHttpRequest.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int QuantidadeEstoque { get; set; }

        public string Categoria { get; set; }

        public string ImagemUrl { get; set; }
    }
}