using ASPTDDComMoq.Entities;
using System.Collections.Generic;

namespace ASPTDDComMoq.Services
{
    public interface IContatoService
    {
        IEnumerable<Contato> ObterTodosContatos();
    }
}
