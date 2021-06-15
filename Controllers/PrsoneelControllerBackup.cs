//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using HotBargainVbEx.Data;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;



//namespace HotBargainVbEx.Controllers
//{
//    public class PersoneelController : Controller
//    {
//        private readonly HotBargainsDbContext _context;
//        private readonly IHostingEnvironment _hostingEnvironment;

//        public PersoneelController(HotBargainsDbContext context, IHostingEnvironment hostingEnvironment)
//        {
//            _context = context;
//            _hostingEnvironment = hostingEnvironment;
//        }


//        public async Task<IActionResult> Index()
//        {
//            ViewBag.wwwDir = _hostingEnvironment.WebRootPath + "\\images";
//            return View( await _context.Personeelsleden.ToListAsync() );
//        }
//    }
//}
