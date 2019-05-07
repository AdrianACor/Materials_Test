using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaterialsWEB.Models;

namespace MaterialsWEB.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            Customers CustList = new Customers();
            using (MaterialsEntities MELS = new MaterialsEntities())
            {
                CustList.BuildingsCol = MELS.Buildings.ToList<Buildings>();
            }
            return View(CustList);
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(Customers DataCustomers)
        {
            try
            {
                using (MaterialsEntities MEDB = new MaterialsEntities())
                {
                    MEDB.InsertCustomers(DataCustomers.Customer,DataCustomers.Prefix,
                        DataCustomers.FKBuilding, DataCustomers.Available);
                    MEDB.SaveChanges();
                }

                return RedirectToAction("/Home/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
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

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
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
