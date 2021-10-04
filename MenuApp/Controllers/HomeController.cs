using MenuApp.Data;
using MenuApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static MenuApp.Models.Menuclass;

namespace MenuApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MenuContext _menuContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MenuContext menuContext)
        {
            _menuContext = menuContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ParentList asdfg = new ParentList();

            Menuclass menuclass = new Menuclass()
            {

                IdMenu = Guid.NewGuid(),
                ParentId = Guid.NewGuid(),
            };
            return View(menuclass);

        }
     

        public IActionResult GetStudentsData()
        {
            List<Menuclass> menuclasses = new List<Menuclass>();
            menuclasses = _menuContext.menuclasses.Select(q =>q).ToList();
            return Json(new { data = menuclasses });
        }

        [HttpPost]
        public IActionResult DeleteStudentDetails(int id)
        {

            if (id == 0)
            {
                return NotFound();
            }

            var qw = _menuContext.menuclasses.Where(w => w.Id == id).FirstOrDefault();
            _menuContext.menuclasses.Remove(qw);
            _menuContext.SaveChanges();
            ViewData["deletedone"] = "Records successfully deleted.";
            return RedirectToAction("Index");
            //return Json(new {success = true, message="Successfully Deleted" }, System.Web.Mvc.JsonRequestBehavior.AllowGet);


        }

        [HttpGet]
        public IActionResult StudentDetails()
        {
            Menuclass menuclass = new Menuclass()
            {
                IdMenu = Guid.NewGuid(),
                IsMenu=false
            };
            return View(menuclass);
        }

        [HttpPost]
        public IActionResult StudentDetails(Menuclass menuclass)
        {
            int updt = menuclass.Id;
            if (updt > 0)
            {
                _menuContext.Entry(menuclass).State = EntityState.Modified; // menuclasses.Update(menuclass);
                _menuContext.SaveChanges();
                ModelState.Clear();
                return View("Index");
            }
            else
            {
                _menuContext.menuclasses.Add(menuclass);
                _menuContext.SaveChanges();
                ModelState.Clear();
                return View("Index");
            }
        }
        [HttpGet]
        public IActionResult TeacherDetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TeacherDetails(int Id)
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
