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
            return View();
        }




        [HttpPost]
        public IActionResult Login (LoginViewModel model)
        {


            if (ModelState.IsValid)
            {

                if(model.Username == "admin")
                {
                    //username: admin
                    //password: 1234

                    ViewBag.Mensaje = "Login exitoso";
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("", "Usuario o contraseña incorrectos");
                }


                return View(model);
            }

            return View(model);
  
          
        }

    }
  
}
