using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppStore.Web.Models;

namespace AppStore.Web.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.MyUserInfo.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyUserInfo myUserInfo = db.MyUserInfo.Find(id);
            if (myUserInfo == null)
            {
                return HttpNotFound();
            }
            return View(myUserInfo);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MyUserInfoId,FirstName,Surname,IsEnabled")] MyUserInfo myUserInfo)
        {
            if (ModelState.IsValid)
            {
                db.MyUserInfo.Add(myUserInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myUserInfo);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyUserInfo myUserInfo = db.MyUserInfo.Find(id);
            if (myUserInfo == null)
            {
                return HttpNotFound();
            }
            return View(myUserInfo);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MyUserInfoId,FirstName,Surname,IsEnabled")] MyUserInfo myUserInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myUserInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myUserInfo);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyUserInfo myUserInfo = db.MyUserInfo.Find(id);
            if (myUserInfo == null)
            {
                return HttpNotFound();
            }
            return View(myUserInfo);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyUserInfo myUserInfo = db.MyUserInfo.Find(id);
            db.MyUserInfo.Remove(myUserInfo);
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
