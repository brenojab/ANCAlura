using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaCodigoVS.Models
{
  public class Produto
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(int id, string nome, decimal preco)
    {
      this.Id = id;
      this.Nome = nome;
      this.Preco = preco;
    }
  }
}
