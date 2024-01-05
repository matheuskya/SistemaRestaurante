using Microsoft.AspNetCore.Mvc;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Controllers
{
    public class ClienteController : Controller
    {
        private readonly RestauranteDbContext _context;
        public ClienteController(RestauranteDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var objClienteList = _context.Clientes.ToList();
            return View(objClienteList);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Cliente obj)
        {
            _context.Clientes.Add(obj); 
            _context.SaveChanges();
            return RedirectToAction("Index","Cliente");
        }
    }
}
