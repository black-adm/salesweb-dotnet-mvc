using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWeb.Models;

namespace SalesWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index() 
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos" }); 
            list.Add(new Department { Id = 2, Name = "Roupas" }); 
            return View(list);
        }
    }
}
