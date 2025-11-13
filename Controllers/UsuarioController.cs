using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_sena.Models;
using proyecto_sena.services;

namespace proyecto_sena.Controllers
{

    [Route("user")]
    public class Usuariocontroller : Controller
    {

        private readonly Iusuarioservice usuarioservice;
        public Usuariocontroller(Iusuarioservice usuarioservice)
        {
            this.usuarioservice = usuarioservice;
        }

        [HttpPost]
        [Route("register")]

        public async Task<ActionResult> Register(usuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                await usuarioservice.Crearusuario(usuario);
                return RedirectToAction("Index","Home");
            }
             return View(usuario);

        }

        [HttpGet]
        [Route("register")]
    public IActionResult Register()
        {
            return View();
        }
    }
    
}

/**/