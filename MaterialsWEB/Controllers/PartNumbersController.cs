using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaterialsWEB.Models;

namespace MaterialsWEB.Controllers
{
    public class PartNumbersController : Controller
    {
        // GET: PartNumbers
        public ActionResult Index()
        {
            return View();
        }

        // GET: PartNumbers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PartNumbers/Create
        public ActionResult Create()
        {
            PartNumbers PartNList = new PartNumbers();
            using (MaterialsEntities MELS = new MaterialsEntities())
            {
                PartNList.CustomersCol = MELS.Customers.ToList<Customers>();
            }
            return View(PartNList);
        }

        // POST: PartNumbers/Create
        [HttpPost]
        public ActionResult Create(PartNumbers DataPartNumbers)
        {
            try
            {
                using (MaterialsEntities MEDB = new MaterialsEntities())
                {
                    MEDB.InsertPartNumber(DataPartNumbers.PartNumber, DataPartNumbers.FKCustomer,
                                            DataPartNumbers.Available);
                    MEDB.SaveChanges();
                }

                return RedirectToAction("/Home/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PartNumbers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartNumbers/Edit/5
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

        // GET: PartNumbers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartNumbers/Delete/5
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
