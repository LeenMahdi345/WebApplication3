using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDBcontext context= new ApplicationDBcontext(); 
        public IActionResult Index()
        {
            var employees =context.Employees.ToList(); 
            return View("Index", employees);
        }
    }
}
