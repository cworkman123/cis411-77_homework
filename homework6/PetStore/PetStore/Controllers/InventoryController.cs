using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class InventoryController : Controller
    {
        private ManageDBContext db = new ManageDBContext();

        // GET: /Inventory/
        public ActionResult Index(string searchString)
        {
            var manages = from m in db.Manages
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                manages = manages.Where(s => s.Name.Contains(searchString));
            }

            return View(manages);
        }

        // GET: /Inventory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manage manage = db.Manages.Find(id);
            if (manage == null)
            {
                return HttpNotFound();
            }
            return View(manage);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
