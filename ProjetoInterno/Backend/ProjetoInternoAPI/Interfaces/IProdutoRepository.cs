using ProjetoInternoAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoAPI.Interfaces
{
    interface IProdutoRepository
    {
        List<Produto> ListarTodas();
        void Cadastrar(Produto produto);
        void Deletar(int idProduto);
        Produto BuscarPorId(int idProduto);

    }
}
