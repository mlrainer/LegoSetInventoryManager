using System;
using LegoSetInventoryManager.Data;
using LegoSets;
using Microsoft.AspNetCore.Mvc;

namespace LegoSetInventoryManager.Controllers
{
    public class LegoSetController : Controller
    {
        private DBContext _context;
        public LegoSetController()

        {

            _context = new DBContext();

        }


        protected override void Dispose(bool disposing) => _context.Dispose();

        [Route("SetName/Index")]

        public ActionResult Index()

        {

            var SetList = _context.SetName;

            return View("Index", SetList);

        }

        public ActionResult New()

        {

            var set = new LegoSets.SetName();

            return View("SetForm", set);

        }

        public ActionResult Save(SetName set)

        {

            if (!ModelState.IsValid)

            {

                var _set = set;


                return View("SetForm", set);

            }


            _context.SetName.Add(set);


            _context.SaveChanges();


            return RedirectToAction("Index", "Set Name");

        }
    }

}