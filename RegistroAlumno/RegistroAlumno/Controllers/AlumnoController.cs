using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistroAlumno.Models.ListViewModel;
using RegistroAlumno.Models;

namespace RegistroAlumno.Controllers
{
    public class AlumnoController : Controller
    {

        public int id;
        // GET: Alumno
        public ActionResult Index()
        {
            List<ListAlumnoViewModel> lst;
            using (RegistroData db = new RegistroData())
            {
                lst = (from d in db.alm_alumno
                       select new ListAlumnoViewModel
                       {
                           Alm_id = d.alm_id,
                           Alm_nombre = d.alm_nombre,
                           Alm_edad = d.alm_edad,
                           Alm_sexo = d.alm_sexo,
                           Alm_id_grd = d.alm_id_grd,
                           Alm_observaciones = d.alm_observaciones,
                           Created_at = d.created_at,
                           Updated_at = d.update_at

                       }).ToList();
            }

            return View(lst);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumno/Create
        public ActionResult Nuevo()
        {
            /*List<ListGradoViewModel> lst;*/
            /* using (RegistroData db = new RegistroData())
             {
                 lst = (from d in db.grd_grado
                        select new ListGradoViewModel
                        {
                            Grd_id = d.grd_Id,
                            Grd_nombre = d.grd_Nombre
                        }).ToList();
             }*/
            /*List<SelectListItem> items = lst.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Grd_nombre.ToString(),
                    Value = d.Grd_id.ToString(),
                    Selected = false
                    
                    
               
                };

                
            });*/
            RegistroData db = new RegistroData();
            ViewBag.items = db.grd_grado.ToList();
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Nuevo(AlumnoViewModel model)
        {
            try
            {

                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    using (RegistroData db = new RegistroData())
                    {
                        var oAlumno = new alm_alumno();

                        oAlumno.alm_id = model.Alm_id;
                        oAlumno.alm_nombre = model.Alm_nombre;
                        oAlumno.alm_edad = model.Alm_edad;
                        oAlumno.alm_sexo = model.Alm_sexo;
                        oAlumno.alm_id_grd = model.Alm_id_grd;
                        oAlumno.alm_observaciones = model.Alm_observaciones;
                        oAlumno.created_at = model.Created_at;
                        oAlumno.update_at = model.Updated_at;

                        db.alm_alumno.Add(oAlumno);
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

        // GET: Alumno/Edit/5

        public ActionResult Editar(int id)
        {
            AlumnoViewModel oAlumno = new AlumnoViewModel();
            using (RegistroData db = new RegistroData())
            {
                var i = db.alm_alumno.Find(id);
                oAlumno.Alm_id= i.alm_id;
                oAlumno.Alm_nombre = i.alm_nombre;
                oAlumno.Alm_edad = i.alm_edad;
                oAlumno.Alm_sexo = i.alm_sexo;
                oAlumno.Alm_id_grd = i.alm_id_grd;
                oAlumno.Alm_observaciones = i.alm_observaciones;
                oAlumno.Created_at = i.created_at;
                oAlumno.Updated_at = i.update_at;
            }
            return View(oAlumno);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Editar(AlumnoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (RegistroData db = new RegistroData())
                    {
                        var oAlumno = db.alm_alumno.Find(model.Alm_id);

                        oAlumno.alm_id = model.Alm_id;
                        oAlumno.alm_nombre = model.Alm_nombre;
                        oAlumno.alm_edad = model.Alm_edad;
                        oAlumno.alm_sexo = model.Alm_sexo;
                        oAlumno.alm_id_grd = model.Alm_id_grd;
                        oAlumno.alm_observaciones = model.Alm_observaciones;
                        //oAlumno.created_at = model.Created_at;
                        oAlumno.update_at = model.Updated_at;

                        db.Entry(oAlumno).State = System.Data.Entity.EntityState.Modified;
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

        // GET: Alumno/Delete/5

        public ActionResult Eliminar(int id)
        {
            using (RegistroData db = new RegistroData())
            {
                var i = db.alm_alumno.Find(id);
                db.alm_alumno.Remove(i);
                db.SaveChanges();

            }
            return RedirectToAction("/");
        }

        // POST: Alumno/Delete/5
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
