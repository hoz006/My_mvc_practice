using Microsoft.AspNetCore.Mvc;
using WebApplication.Service.Service;

namespace WebApplication.Mvc.Controllers
{
    public class ToDoListController : Controller
    {
        private ToDoListService toDoListService;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var result = toDoListService.GetAll();
            return Json("");
        }
    }
}
