using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class UserHomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserHomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult UserHome()
        {
            return View(_context.Good.ToList());
        }
    }
}
