using Sis.DataAccess.Repository.IRepository;
using Sis.Models;
using SistemaRestaurante.Sis.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sis.DataAccess.Repository
{
    internal class ClienteRepository : Repository<Cliente>, IClienteInterface
    {
        private RestauranteDbContext _db;
        public ClienteRepository(RestauranteDbContext db) : base(db)
        {
            _db = db;
        }       

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Cliente obj)
        {
            _db.Clientes.Update(obj);
        }
    }
}
