using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OCTO_CRUD.Models;

namespace OCTO_CRUD.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientContext _context;

        public ClientsController(ClientContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

        // GET: Clients/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Client());
            else
                return View(_context.Clients.Find(id));
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("IdClient,FullName,ZipCode,Cnpj,CellPhone,HomePhone,CommercialPhone")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(client);

        }

        // GET: Clients/Delete/
        public async Task<IActionResult> Delete(int? id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
