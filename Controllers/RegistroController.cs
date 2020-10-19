using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc1lab.Data;
using pc1lab.Models;

namespace pc1lab.Controllers
{
    public class RegistroController : Controller
    {

       private readonly ILogger<RegistroController> _logger;

       private readonly DatabaseContext _context;

        public RegistroController(ILogger<RegistroController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public DatabaseContext Context { get; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Registro objRegsitro){
            if (ModelState.IsValid)
            {
               _context.Add(objRegsitro);
                _context.SaveChanges();
                objRegsitro.Response = "Patricia Elizabeth Zambrano Carpio";
            }
            return View("index", objRegsitro);
        }

    }
}