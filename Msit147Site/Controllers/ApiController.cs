using Microsoft.AspNetCore.Mvc;
using Msit147Site.Models;

namespace Msit147Site.Controllers
{
    
        
    public class ApiController : Controller
    {
        private readonly DemoContext _context;
        public ApiController(DemoContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return Content("<h2>Hello!!</h2>","text/html");
        }

        public IActionResult Cities() 
        {
            var cities = _context.Address.Select(c => c.City).Distinct();

            return Json(cities);
        }

        public IActionResult Districts(string city) {
        var districts = _context.Address.Where(x=>x.City==city).Select(x=>x.SiteId).Distinct();
            return Json(districts);
        }

        public IActionResult Roads(string districts)
        {
            var roads = _context.Address.Where(o => o.SiteId== districts).Select(x => x.Road).Distinct();
            return Json(roads);
        }

        public IActionResult CheckAcount(string name) 
        {
            var confirm = _context.Members.FirstOrDefault(x => x.Name==name);
            return Json(confirm);
        }
    }
}
