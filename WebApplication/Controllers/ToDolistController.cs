using Microsoft.AspNetCore.Mvc;
using WebApplication.Service.Service;

namespace WebApplication.Mvc.Controllers
{
    public class ToDolistController : Controller
    {
        private readonly ToDoListService toDoListService;

        public ToDolistController()
        {
            toDoListService = new ToDoListService();
        }

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
