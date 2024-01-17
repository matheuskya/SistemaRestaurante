using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaRestauranteRazor.Data;
using SistemaRestauranteRazor.Models;

namespace SistemaRestauranteRazor.Pages.ClientePage
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Cliente> ClientesList { get; set; }

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ClientesList = _context.Clientes.ToList();
        }
    }
}
