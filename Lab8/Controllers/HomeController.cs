using Lab8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8.Controllers
{
    public class HomeController : Controller
    {
        ShoeContext db;
        public HomeController(ShoeContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Shoes.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public string Create(Shoe shoe)
        {
            db.Shoes.Add(shoe);
            db.SaveChanges();
            return "Shoe " + shoe.Name + " created";
        }
    }
}
