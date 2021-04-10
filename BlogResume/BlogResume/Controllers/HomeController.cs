using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogResume.Models;
using DataAccessLayer;
using X.PagedList;

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
            ViewBag.BaiViets = baiViets.Reverse().ToList();

            return View();
        }

        public IActionResult Work()
        {
            return View();
        }

        public async Task<IActionResult> Blog(int ? page)
        {
            var baiViets = await _repository.BaiViet.GetAllBaiVietsAsync();
            var chuDes = await _repository.ChuDe.GetAllChuDesAsync();
            int pageNumber = page ?? 1;

            ViewBag.BaiViets = baiViets.Reverse().ToList();
            ViewBag.BaiVietToPage = baiViets.ToList().ToPagedList(pageNumber, 2);

            ViewBag.ChuDes = chuDes;
            return View();
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            var baiViets = await _repository.BaiViet.GetAllBaiVietsAsync();
            var baiVietDetail = await _repository.BaiViet.GetBaiVietByIdAsync(id);
            var chuDes = await _repository.ChuDe.GetAllChuDesAsync();

            ViewBag.BaiViets = baiViets.Reverse().ToList();
            ViewBag.ChuDes = chuDes;
            ViewBag.BaiViet = baiVietDetail;
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
