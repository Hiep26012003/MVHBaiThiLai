using Microsoft.AspNetCore.Mvc;

namespace MVHBaiThiLai.Controllers{
    public class MVH753 : Controller{
        public IActionResult Index (){
            return View();
        }
        [HttpPost]
        public IActionResult Index (string X){
            X = "Xin Chao";
            int age;
            string name ="xin chao";
        
        ViewData["x"] = X + name;
        return View();
        }
   }
}