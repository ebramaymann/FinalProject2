using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class CatgController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CatgController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult banio()
        {
            var query = from k in _context.Good
                        join a in _context.typeGoods on k.Idtg equals a.Id
                        where k.Idtg == 9 // replace with your varialble.orderby a.City
                        select k;
            return View(query);
        }
        public IActionResult ahwad()
        {
            var query = from k in _context.Good
                        join a in _context.typeGoods on k.Idtg equals a.Id
                        where k.Idtg == 4 // replace with your varialble.orderby a.City
                        select k;
            return View(query);
        }
        public IActionResult marahid()
        {
            var query = from k in _context.Good
                        join a in _context.typeGoods on k.Idtg equals a.Id
                        where k.Idtg == 6 // replace with your varialble.orderby a.City
                        select k;
            return View(query);
        }
        public IActionResult khalat()
        {
            var query = from k in _context.Good
                        join a in _context.typeGoods on k.Idtg equals a.Id
                        where k.Idtg == 6 // replace with your varialble.orderby a.City
                        select k;
            return View(query);
        }
        public IActionResult acc()
        {
            var query = from k in _context.Good
                        join a in _context.typeGoods on k.Idtg equals a.Id
                        where k.Idtg == 7 // replace with your varialble.orderby a.City
                        select k;
            return View(query);
        }
        public IActionResult sebaka()
        {
            var query = from k in _context.Good
                        join a in _context.typeGoods on k.Idtg equals a.Id
                        where k.Idtg == 8 // replace with your varialble.orderby a.City
                        select k;
            return View(query);
        }
    }
}
