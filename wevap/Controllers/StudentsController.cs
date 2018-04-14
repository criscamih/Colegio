using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using wevap.Context;
using wevap.Datos;
using wevap.Models;

namespace wevap.Controllers
{
    public class StudentsController : Controller
    {
        private SDBcontext db = new SDBcontext();
        private SubjectLevelData subjectLevelData = new SubjectLevelData();
        private LevelData levelData = new LevelData();


        // GET: Students
        public ActionResult Index()
        {
            return View(db.tblStudent.ToList());

        }
        public ActionResult StudentList()
        {
            return View(db.tblStudent.ToList());
        }
        //get para añadir la cantidad de cursos
        public ActionResult AddStudentSubject(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.tblStudent.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            ViewBag.query = subjectLevelData.GetQuerySubjectLevel();
            ViewBag.level = levelData.GetLevels();
            return View(student);

            
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudentSubject(Student student,int[] items=null)
        {
            return RedirectToAction("StudentList");
        }
        //get para que docente añada las notas
        public ActionResult AddTeacherScore()
        {
            
            return View();
        }
        // GET: Students/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.tblStudent.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DNI,NameStudent,DateInput,DateOutput")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.tblStudent.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.tblStudent.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DNI,NameStudent,DateInput,DateOutput")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.tblStudent.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student student = db.tblStudent.Find(id);
            db.tblStudent.Remove(student);
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
