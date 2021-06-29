using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistroAlumno.Models;
using RegistroAlumno.Models.ListViewModel;

namespace RegistroAlumno.Controllers
{
    public class GradoController : Controller
    {
        // GET: Grado
        public ActionResult Index()
        {
            List<ListGradoViewModel> lst;
            using(RegistroData db = new RegistroData())
            {
                lst = (from d in db.grd_grado
                       select new ListGradoViewModel
                       {

                           Grd_id = d.grd_Id,
                           Grd_nombre = d.grd_Nombre,
                           Created_at = d.created_at,
                           Updated_at = d.updated_at

                       }).ToList();
            }

            return View(lst);
        }

        // GET: Grado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grado/Create
        public ActionResult Nuevo()
        {
            return View();
        }

        // POST: Grado/Create
        [HttpPost]
        public ActionResult Nuevo(GradoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (RegistroData db = new RegistroData())
                    {
                        var oGrado = new grd_grado();

                        oGrado.grd_Id= model.Grd_id;
                        oGrado.grd_Nombre = model.Grd_nombre;
                        oGrado.created_at = model.Created_at;
                        oGrado.updated_at = model.Updated_at;

                        db.grd_grado.Add(oGrado);
                        db.SaveChanges();
                        


                    }
                    return RedirectToAction("/");
                }
                return View(model);

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Grado/Edit/5
        public ActionResult Editar(int id)
        {
            GradoViewModel grado = new GradoViewModel();
            using(RegistroData db= new RegistroData())
            {
                var i = db.grd_grado.Find(id);
                grado.Grd_id = i.grd_Id;
                grado.Grd_nombre = i.grd_Nombre;
                grado.Created_at = i.created_at;
                grado.Updated_at = i.updated_at;
            }
            return View(grado);
        }

        // POST: Grado/Edit/5
        [HttpPost]
        public ActionResult Editar(GradoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (RegistroData db = new RegistroData())
                    {
                        var i = db.grd_grado.Find(model.Grd_id);

                        i.grd_Id = model.Grd_id;
                        i.grd_Nombre = model.Grd_nombre;
                        i.created_at = model.Created_at;
                        i.updated_at = model.Updated_at;

                        db.Entry(i).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();



                    }
                    return RedirectToAction("/");
                }
                return View(model);


            }
            catch
            {
                return View();
            }
        }

        // GET: Grado/Delete/5
        public ActionResult Eliminar(int id)
        {
            
            using (RegistroData db = new RegistroData())
            {
                var i = db.grd_grado.Find(id);
                db.grd_grado.Remove(i);
                db.SaveChanges();

            }
            return RedirectToAction("/");
        }

        // POST: Grado/Delete/5
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
