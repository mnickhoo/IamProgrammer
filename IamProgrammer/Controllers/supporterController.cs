using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IamProgrammer.Models;
using IdentitySample.Models;

namespace IamProgrammer.Controllers
{
    public class supporterController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: supporter
        public ActionResult Index()
        {
            return View(db.Supporters.ToList());
        }

        // GET: supporter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            supporterModel supporterModel = db.Supporters.Find(id);
            if (supporterModel == null)
            {
                return HttpNotFound();
            }
            return View(supporterModel);
        }

        // GET: supporter/Create
        public ActionResult Create()
        {
            ViewBag.Skills = db.Skills.ToList().Select(skill => new SelectListItem { Text = skill.Title, Value = skill.Id.ToString() });
            return View();
        }

        // POST: supporter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Family,Email,Phone,skillId,SubscribeEmail,Date")] supporterModel supporterModel)
        {
            if (ModelState.IsValid)
            {
                //supporterModel.Skill.Id = 12; 
                db.Supporters.Add(supporterModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: supporter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            supporterModel supporterModel = db.Supporters.Find(id);
            if (supporterModel == null)
            {
                return HttpNotFound();
            }
            return View(supporterModel);
        }

        // POST: supporter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Family,Email,Phone,Gender,SubscribeEmail,IsWorking")] supporterModel supporterModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supporterModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supporterModel);
        }

        // GET: supporter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            supporterModel supporterModel = db.Supporters.Find(id);
            if (supporterModel == null)
            {
                return HttpNotFound();
            }
            return View(supporterModel);
        }

        // POST: supporter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            supporterModel supporterModel = db.Supporters.Find(id);
            db.Supporters.Remove(supporterModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult IsUniqueEmail(string Email)
        {
            var supporter = (from x in db.Supporters
                             where x.Email == Email
                             select x).FirstOrDefault();
            bool response = supporter == null ? true : false; 
            return Json(response, JsonRequestBehavior.AllowGet);
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
