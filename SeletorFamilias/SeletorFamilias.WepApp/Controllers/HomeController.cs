using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeletorFamilias.WepApp.DAO;
using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFamiliaDAO _familiaDAO;

        public HomeController(ILogger<HomeController> logger, IFamiliaDAO familiaDAO)
        {
            _familiaDAO = familiaDAO;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ranking()
        {
            return View();
        }

        public IActionResult PosCadastro()
        {
            return View();
        }

        public IActionResult CadastrarDependente()
        {
            return View();
        }

        public IActionResult CadastrarFamilia()
        {
            return View();
        }
    }
}
