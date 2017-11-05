using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaCodigoVS.Models
{
  public class ItemPedido
  {
    public int Id { get; private set; }
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; private set; }
    public decimal Subtotal
    {
      get
      {
        return Quantidade * PrecoUnitario;
      }
    }

    public ItemPedido(int id, Produto produto, int quantidade, decimal precoUnitario)
    {
      Id = id;
      Produto = produto;
      Quantidade = quantidade;
      PrecoUnitario = precoUnitario;
    }
  }
}
