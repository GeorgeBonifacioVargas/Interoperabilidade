using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using XMLHttpRequest.Models;

namespace XMLHttpRequest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
