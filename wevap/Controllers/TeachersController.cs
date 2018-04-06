using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using wevap.Context;
using wevap.Datos;
using wevap.Models;

namespace wevap.Controllers
{
    public class TeachersController : Controller
    {
        private SDBcontext db = new SDBcontext();
        private SubjectData subject = new SubjectData();
        private TeacherData teacherData = new TeacherData();
        private Teacher teacherGlobal = new Teacher();
        // GET: Teachers
        public ActionResult Index()
        {
            return View(db.tblTeacher.ToList());
        }
        public ActionResult TeacherList()
        {
            return View(db.tblTeacher.ToList());
        }
        public ActionResult ScoreTeacher(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.tblTeacher.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }
        //GEt Vista para asignar materias al docente
        public ActionResult SubjectTeacher(string id = null)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.tblTeacher.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            else
            {
                ViewBag.subjects = subject.GetSubjects();
                return View(teacher);
            }

        }
        //Asignar materias a profesores
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubjectTeacher(string id, int[] subjects = null)
        {
            Teacher teacher = db.tblTeacher.Find(id);
            var lista = teacher.Subjects.ToList();
            if (teacher.Subjects.Count > 0)
            {
                lista.Clear(); 
                teacher.Subjects = lista;
            }
            
  
           if(subjects!=null)
            {
                foreach (var s in subjects)
                {
                    teacher.Subjects.Add(new Subject { Id_Subject = s });
                }
                teacherData.SaveTeacherSubject(teacher);
                return RedirectToAction("TeacherList");
            }
            else
            {
                return View();
            }
            
        }
        // GET: Teachers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.tblTeacher.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: Teachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DNI,NameTeacher")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.tblTeacher.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.tblTeacher.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DNI,NameTeacher")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.tblTeacher.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Teacher teacher = db.tblTeacher.Find(id);
            db.tblTeacher.Remove(teacher);
            db.SaveChanges();
            return RedirectToAction("Index");
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
