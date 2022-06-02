﻿using InjecaoDepencia.Models;
using InjecaoDepencia.Service;
using InjecaoDepencia.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDepencia.Controllers
{
    public class UsuarioController : Controller
    {
        IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var usuarios = _service.ListarUsuario();

            return View();
        }


    }
}
