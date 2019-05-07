using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaterialsWEB.Models;

namespace MaterialsWEB.Controllers
{
    public class BuildingsController : Controller
    {
        // GET: Buildings
        public ActionResult Index()
        { using (MaterialsEntities MDB = new MaterialsEntities())
            {
                return View(MDB.Buildings.ToList());
            }
                
        }

        // GET: Buildings/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buildings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buildings/Create
        [HttpPost]
        public ActionResult Create(Buildings DataBuilding)
        {
            try
            {
                using (MaterialsEntities MEDB = new MaterialsEntities())
                {
                    MEDB.InsertBuildings(DataBuilding.Building, DataBuilding.Available);
                    MEDB.SaveChanges();
                }

                return RedirectToAction("/Home/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Buildings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buildings/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Buildings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buildings/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
