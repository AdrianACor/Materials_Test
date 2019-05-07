using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaterialsWEB.Models;

namespace MaterialsWEB.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta
        public ActionResult Index(String partNumber, String Customer)
        {

            using (MaterialsEntities MDB = new MaterialsEntities())

            return View(MDB.consultaP(partNumber, Customer).ToList());
        }
        
    }
}
