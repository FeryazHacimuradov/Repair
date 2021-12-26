using Microsoft.AspNetCore.Mvc;
using RepairApp.Data;
using RepairApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Controllers
{
    public class BlogHomeController : Controller
    {
        private readonly AppDbContext _context;
        public BlogHomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            VmHome model = new VmHome();

            model.Blog = _context.Blogs.Find(id);
            return View(model);
        }
    }
}
