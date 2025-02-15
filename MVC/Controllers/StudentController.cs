using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers{
    public class StudentController : Controller{
        public IActionResult Index()
        {
        return View();    
        }
        [HttpPost]
         public IActionResult Index(string fullName,string StudentCode,string Address)
        {
            ViewBag.Message = $"Xin chào {fullName},có mã sinh viên là {StudentCode},sống ở :{Address}";
        return View();    
        }
    }
}