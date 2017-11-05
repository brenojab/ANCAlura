using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CasaCodigoVS.Models;
using CasaCodigoVS.Models.ViewModels;

namespace CasaCodigoVS.Controllers
{
  public class PedidoController : Controller
  {
    List<Produto> produtos = new List<Produto>
        {
          new Produto(1,"Sleep not found", 59.90M),
          new Produto(2,"May the code be with you", 59.90M),
          new Produto(3,"Rollback", 59.90M),
          new Produto(4,"REST", 69.90M),
          new Produto(5,"Design Patterns com Java", 69.90M),
          new Produto(6,"Vire o jogo com Spring Framework", 69.90M),
          new Produto(7,"Test-Driven Development", 69.90M),
          new Produto(8,"iOS: Programe para iPhone e iPad", 69.90M),
          new Produto(9,"Desenvolvimento de Jogos para Android", 69.90M)
        };

    public IActionResult Carrossel()
    {
      return View(produtos);
    }

    public IActionResult Carrinho()
    {
      return View(GetCarrinhoViewModel());

    }

    private CarrinhoViewModel GetCarrinhoViewModel()
    {
      List<ItemPedido> itensCarrinho = new List<ItemPedido>
      {
        new ItemPedido(1,produtos[0],1,produtos[0].Preco),
        new ItemPedido(2,produtos[1],2,produtos[1].Preco),
        new ItemPedido(3,produtos[2],3,produtos[2].Preco)
      };

      return new CarrinhoViewModel(itensCarrinho);
    }

    public IActionResult Resumo()
    {
      return View(GetCarrinhoViewModel());

    }
  }
}