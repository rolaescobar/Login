using Login.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class AccountController : Controller
    {


        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.HideMenu = true;
            return View();
        }




        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "1234")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Usuario o contraseña incorrectos");
                }
            }

            ViewBag.HideMenu = true; // importante también en el POST fallido
            return View(model);
        }

    }
  
}
