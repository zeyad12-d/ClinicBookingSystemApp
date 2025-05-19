using ClinicBookingSystemAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicBookingSystemAPP.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            var departemnts = new List<Department>
            {
                new Department { Id = 1, Name = "Cardiology" },
                new Department { Id = 2, Name = "Neurology" },
                new Department { Id = 3, Name = "Pediatrics" }
            };
            return View(departemnts);
        }
    }
}
