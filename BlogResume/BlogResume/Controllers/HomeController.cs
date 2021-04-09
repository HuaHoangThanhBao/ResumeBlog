using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogResume.Models;
using DataAccessLayer;

namespace BlogResume.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryWrapper _repository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var baiViets = await _repository.BaiViet.GetAllBaiVietsAsync();
            return View(baiViets);
        }

        public IActionResult Work()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
