using Projeto.Curso.Core.Domain.Pedido.AgregacaoPedidos;
using System.Collections.Generic;

namespace Projeto.Curso.Core.Domain.Pedido.Interfaces.Repository.AgregacaoPedidos
{
    public interface IRepositorioPedidos : IRepository<Pedidos>
    {
        void AdicionarItensPedidos(ItensPedidos item);
        void AtulizarItensPedidos(ItensPedidos item);
        void RemoverItensPedidosPedidos(ItensPedidos item);
        ItensPedidos ObterItensPedidosPorId(int id);
        IEnumerable<ItensPedidos> ObterItensPedido(int idpedido);

    }
}
