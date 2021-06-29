using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistroAlumno.Models;
using RegistroAlumno.Models.ListViewModel;

namespace RegistroAlumno.Controllers
{
    public class MateriasGradoController : Controller
    {
        // GET: MateriasGrado
        public ActionResult Index()
        {
            //get data grados
            RegistroData db = new RegistroData();
            List<ListMateriaGradoViewModel> lst;
            var list = db.GradoMateria().ToList();



                 
            return View();
       
        }

        // GET: MateriasGrado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MateriasGrado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MateriasGrado/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MateriasGrado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MateriasGrado/Edit/5
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

        // GET: MateriasGrado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MateriasGrado/Delete/5
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
