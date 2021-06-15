using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotBargainVbEx.Data;
using HotBargainVbEx.Models;
using Microsoft.EntityFrameworkCore;

namespace HotBargainVbEx.Controllers
{
    public class ProjectController : Controller
    {
        private readonly HotBargainsDbContext _context;

        
        public ProjectController(HotBargainsDbContext hotBargainsDbContext)
        {
            _context = hotBargainsDbContext;
        }

        public IActionResult Index()
        {
            // include name = name of DB set
            List<Project> projecten = _context.Projecten.Include("Personeelsleden").ToList();
            return View(projecten);
        }
    }
}
