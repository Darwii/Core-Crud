using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Crud.Models;
using Core_Crud.Data;

namespace Core_Crud.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController1(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<category> objlist = _db.Category;
            return View(objlist);
        }
    }
}
