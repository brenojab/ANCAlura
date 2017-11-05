using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaCodigoVS.Models.ViewModels
{
  public class CarrinhoViewModel
  {
    public List<ItemPedido> Itens { get; private set; }
    public decimal Total
    {
      get
      {
        return Itens.Sum(p => p.Subtotal);
      }
    }

    public CarrinhoViewModel(List<ItemPedido> itens)
    {
      Itens = itens;

    }
  }
}
