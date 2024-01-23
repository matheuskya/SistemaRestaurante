using Sis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis.DataAccess.Repository.IRepository
{
    public interface IClienteInterface : IRepository<Cliente>
    {
        void Update(Cliente obj);
        void Save();
    }
}
