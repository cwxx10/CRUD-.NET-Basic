using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Products" });
            return View(list);
        }
    }
}
