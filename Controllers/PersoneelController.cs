using HotBargainVbEx.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBargainVbEx.Controllers
{
    public class PersoneelController : Controller
    {
        private readonly HotBargainsDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PersoneelController(HotBargainsDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.wwwDir = _hostingEnvironment.WebRootPath + "\\images";
            return View(await _context.Personeelsleden.ToListAsync());
        }

        // GET: PersoneelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersoneelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersoneelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersoneelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersoneelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersoneelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersoneelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
