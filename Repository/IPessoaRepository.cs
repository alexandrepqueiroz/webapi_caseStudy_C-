using System.Collections.Generic;
using webapi.Model;

namespace webapi.Repository
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
    }
}