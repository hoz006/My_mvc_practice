using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication.Service.Service;

namespace WebApplication.Mvc.Controllers
{
    public class ToDoListController : Controller
    {
        private ToDoListService toDoListService;

        public ToDoListController()
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
            return View(result);
        }
    }
}
