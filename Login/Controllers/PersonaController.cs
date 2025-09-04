using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class PersonaController : Controller
    {
        
        public ActionResult Persona()
        {
            return View();
        }

        public ActionResult ListaPersona()
        {
            return View();
        }

    }
}
