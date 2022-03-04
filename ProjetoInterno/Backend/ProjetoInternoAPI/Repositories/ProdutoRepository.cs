using ProjetoInternoAPI.Contexts;
using ProjetoInternoAPI.Domains;
using ProjetoInternoAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        ClassificadosContext ctx = new ClassificadosContext();
        public Produto BuscarPorId(int idProduto)
        {
            return ctx.Produtos.FirstOrDefault(c => c.IdProduto == idProduto);
        }

        public void Cadastrar(Produto produto)
        {
            ctx.Produtos.Add(produto);
            ctx.SaveChanges();
        }

        public void Deletar(int idProduto)
        {
            ctx.Produtos.Remove(ctx.Produtos.Find(idProduto));
            ctx.SaveChanges();
        }

        public List<Produto> ListarTodas()
        {
            return ctx.Produtos.ToList();
        }
    }
}
