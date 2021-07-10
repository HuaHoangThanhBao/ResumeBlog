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
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

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

        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Home";
            var baiViets = await _repository.BaiViet.GetAllBaiVietsAsync();
            ViewBag.BaiViets = baiViets.Reverse().ToList();

            return View();
        }

        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30, Location = ResponseCacheLocation.Any)]
        public IActionResult Work()
        {
            ViewData["Title"] = "Projects";
            return View();
        }

        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> Blog(int ? page)
        {
            ViewData["Title"] = "Blog";

            var baiViets = await _repository.BaiViet.GetAllBaiVietsAsync();
            var chuDes = await _repository.ChuDe.GetAllChuDesAsync();
            int pageNumber = page ?? 1;

            ViewBag.BaiViets = baiViets.Reverse().ToList();
            ViewBag.BaiVietToPage = baiViets.ToList().ToPagedList(pageNumber, 2);

            ViewBag.ChuDes = chuDes;
            return View();
        }

        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewData["Title"] = "Content";

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
            ViewData["Title"] = "Contact";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Download()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/private/HuaHoangThanhBao_dev.pdf");
            if (!System.IO.File.Exists(filePath))
                return NotFound();
            var memory = new MemoryStream();
            await using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(filePath), filePath);
        }

        private string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;

            if (!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/octet-stream";
            }

            return contentType;
        }
    }
}
