using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistroAlumno.Models;
using RegistroAlumno.Models.ListViewModel;


namespace RegistroAlumno.Controllers
{
    public class MateriaController : Controller
    {
        // GET: Materia
        public ActionResult Index()
        {
            List<ListMateriaViewModel> lst;
            using (RegistroData db = new RegistroData())
            {
                lst = (from d in db.mat_materia
                       select new ListMateriaViewModel
                       {
                           Mat_id = d.mat_id,
                           Mat_nombre = d.mat_nombre,
                           Created_at = d.created_at,
                           Updated_at = d.created_at
                       }


                ).ToList();
            }
            return View(lst);
        }

        // GET: Materia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Materia/Create
        public ActionResult Nuevo()
        {

            return View();
        }

        // POST: Materia/Create
        [HttpPost]
        public ActionResult Nuevo(MateriaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(RegistroData db= new RegistroData())
                    {
                        var oMateria = new mat_materia();
                        
                            oMateria.mat_id = model.Mat_id;
                            oMateria.mat_nombre = model.Mat_nombre;
                            oMateria.created_at = model.Created_at;
                            oMateria.updated_at = model.Updated_at;

                            db.mat_materia.Add(oMateria);
                            db.SaveChanges();
                        

                    }
                    return RedirectToAction("/");
                }
                return View(model);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
           
            
        }


        public ActionResult Editar(int id)
        {
            MateriaViewModel oMateria = new MateriaViewModel();
            using (RegistroData db = new RegistroData())
            {
                var i = db.mat_materia.Find(id);
                oMateria.Mat_id = i.mat_id;
                oMateria.Mat_nombre = i.mat_nombre;
                oMateria.Created_at = i.created_at;
                oMateria.Updated_at = i.updated_at;
            }
            return View(oMateria);
        }

        [HttpPost]
        public ActionResult Editar(MateriaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (RegistroData db = new RegistroData())
                    {
                        var oMateria = db.mat_materia.Find(model.Mat_id);

                        oMateria.mat_id = model.Mat_id;
                        oMateria.mat_nombre = model.Mat_nombre;
                        oMateria.created_at = model.Created_at;
                        oMateria.updated_at = model.Updated_at;

                        db.Entry(oMateria).State = System.Data.Entity.EntityState.Modified;
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

        

        // GET: Materia/Delete/5
        public ActionResult Eliminar(int id)
        {
            using (RegistroData db = new RegistroData())
            {
                var i = db.mat_materia.Find(id);
                db.mat_materia.Remove(i);
                db.SaveChanges();

            }
            return RedirectToAction("/");
        }

        // POST: Materia/Delete/5
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
