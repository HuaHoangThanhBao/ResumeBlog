using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogResume.Controllers
{
    public class AdminController : Controller
    {
        private IRepositoryWrapper _repository;
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AdminController(IWebHostEnvironment hostingEnvironment, ILogger<AdminController> logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Admin()
        {
            var baiViets = await _repository.BaiViet.GetAllBaiVietsAsync();
            var chuDes = await _repository.ChuDe.GetAllChuDesAsync();

            ViewBag.BaiViets = baiViets.Reverse().ToList();
            ViewBag.ChuDes = chuDes;

            return View();
        }

        public async Task<IActionResult> Delete(string baivietID)
        {
            int num;
            if (int.TryParse(baivietID, out num) == true)
            {
                var baiViet = await _repository.BaiViet.GetBaiVietByIdAsync(int.Parse(baivietID));
                _repository.BaiViet.DeleteBaiViet(baiViet);
                _repository.Save();
            }

            return RedirectToAction("Admin", "Admin");
        }

        public IActionResult Add(string idchude, string tieude, string mota, string noidung, IFormFile hinhanh)
        {
            var folderName = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (hinhanh.Length > 0)
            {
                var fileName = hinhanh.FileName;
                var fullPath = Path.Combine(pathToSave, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    hinhanh.CopyTo(stream);
                }

                _repository.BaiViet.AddBaiViet(int.Parse(idchude), tieude, noidung, mota, fileName);
                _repository.Save();
            }
            return RedirectToAction("Admin", "Admin");
        }
    }
}
