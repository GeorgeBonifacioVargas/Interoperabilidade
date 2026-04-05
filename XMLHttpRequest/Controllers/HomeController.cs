using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using XMLHttpRequest.Models;


 class HomeController : Controller
{
    public JsonResult ListarProdutos()
    {
        var produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Notebook Gamer",
                Descricao = "Notebook de alto desempenho para jogos",
                Preco = 7500,
                QuantidadeEstoque = 15,
                Categoria = "Informática",
                ImagemUrl = "/img/notebook.png"
            },

            new Produto
            {
                Id = 2,
                Nome = "Mouse Gamer",
                Descricao = "Mouse com alta precisão para jogos",
                Preco = 250,
                QuantidadeEstoque = 40,
                Categoria = "Acessórios",
                ImagemUrl = "/img/mouse.png"
            }
        };

        return Json(produtos);
    }
}