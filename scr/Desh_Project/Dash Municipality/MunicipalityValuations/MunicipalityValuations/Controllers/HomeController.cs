using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MunicipalityValuations.Models;

namespace MunicipalityValuations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new MunicipalityContext())
            {
                var model = ctx.Municipalitites.Include(m => m.Valuations).ToList();
                return View(model);
            }
        }

        public ActionResult ViewMunicipalityValuations(int? id)
        {
            Municipality model = new Municipality();
            using (var ctx = new MunicipalityContext())
            {
                model = ctx.Municipalitites.Include(m => m.Valuations).FirstOrDefault(m => m.MunicipalityId == id);
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddMunicipality(Municipality model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var ctx = new MunicipalityContext())
            {
                ctx.Municipalitites.Add(model);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddValuation(MunicipalityValuation model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            using (var ctx = new MunicipalityContext())
            {
                ctx.MunicipalityValuations.Add(model);
                ctx.SaveChanges();
            }

            return RedirectToAction("ViewMunicipalityValuations", new {id = model.MunicipalityId});
        }
    }
}