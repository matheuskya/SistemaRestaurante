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
        
        public IActionResult Edit(int? id)
        {
            if(id == null || id== 0)
            {
                return NotFound();
            }
            Cliente IdCliente = _context.Clientes.Find(id);
            if (IdCliente == null)
            {
                return NotFound();
            }
            return View(IdCliente);
        }

        [HttpPost]
       public IActionResult Edit(Cliente obj)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Update(obj);
                _context.SaveChanges();
                TempData["success"] = "Cliente editado com sucesso";

                return RedirectToAction("Index", "Cliente");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Cliente obj)
        {
            if(obj.Name?.ToLower() == "teste")
            {
                ModelState.AddModelError("Name", "O nome teste nao pode ser usado");
            }
            if(ModelState.IsValid)
            {
            _context.Clientes.Add(obj); 
            _context.SaveChanges();
                TempData["success"] = "Cliente cadastrado com sucesso";
                return RedirectToAction("Index", "Cliente");

            }
            return View();

        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Cliente IdCliente = _context.Clientes.Find(id);
            if (IdCliente == null)
            {
                return NotFound();
            }
            return View(IdCliente);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Cliente obj = _context.Clientes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Clientes.Remove(obj);
            _context.SaveChanges();
            TempData["success"] = "Cliente removido com sucesso";

            return RedirectToAction("Index");

        }
    }
}
