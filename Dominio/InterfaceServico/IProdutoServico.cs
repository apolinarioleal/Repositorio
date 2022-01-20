using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceServico
{
    public interface IProdutoServico
    {
        Task<List<Produto>> ListarProdutosComExpression(Expression<Func<Produto, bool>> exProduto);

        Task<List<Produto>> ListarProdutosPorNome(string nome);

        Task AdicionarComValidacao(Produto produto);

    }
}
