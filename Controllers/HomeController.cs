using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;


namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { id = 1, name = "Pragim" });
        }
    }
}