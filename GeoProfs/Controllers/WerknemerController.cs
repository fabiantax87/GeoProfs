using GeoProfs.Data;
using GeoProfs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoProfs.Controllers
{

    public class WerknemerController : Controller
    {
        private readonly GeoProfsContext _context;

        public WerknemerController(GeoProfsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Werknemer> werknemers = _context.Werknemers.ToList();
            return View(werknemers);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Werknemer werknemer = await _context.Werknemers.SingleOrDefaultAsync(item => item.Id == id);

            if(werknemer == null)
            {
                return NotFound();
            }

            return View(werknemer);
        }
    }
}
