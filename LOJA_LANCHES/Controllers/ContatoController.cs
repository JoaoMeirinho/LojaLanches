using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LojaLanches.Controllers
{
  
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
    }
}
