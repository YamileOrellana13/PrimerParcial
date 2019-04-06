using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCparcial.Models;

namespace MVCparcial.Controllers
{
    public class YamileOrellanaFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: YamileOrellanaFriends
        public ActionResult Index()
        {
            return View(db.YamileOrellanaFriends.ToList());
        }

        // GET: YamileOrellanaFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YamileOrellanaFriend yamileOrellanaFriend = db.YamileOrellanaFriends.Find(id);
            if (yamileOrellanaFriend == null)
            {
                return HttpNotFound();
            }
            return View(yamileOrellanaFriend);
        }

        // GET: YamileOrellanaFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YamileOrellanaFriends/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,Name,Type,Nickname,Birthdate,Unidad")] YamileOrellanaFriend yamileOrellanaFriend)
        {
            if (ModelState.IsValid)
            {
                db.YamileOrellanaFriends.Add(yamileOrellanaFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yamileOrellanaFriend);
        }

        // GET: YamileOrellanaFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YamileOrellanaFriend yamileOrellanaFriend = db.YamileOrellanaFriends.Find(id);
            if (yamileOrellanaFriend == null)
            {
                return HttpNotFound();
            }
            return View(yamileOrellanaFriend);
        }

        // POST: YamileOrellanaFriends/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,Name,Type,Nickname,Birthdate,Unidad")] YamileOrellanaFriend yamileOrellanaFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yamileOrellanaFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yamileOrellanaFriend);
        }

        // GET: YamileOrellanaFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YamileOrellanaFriend yamileOrellanaFriend = db.YamileOrellanaFriends.Find(id);
            if (yamileOrellanaFriend == null)
            {
                return HttpNotFound();
            }
            return View(yamileOrellanaFriend);
        }

        // POST: YamileOrellanaFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            YamileOrellanaFriend yamileOrellanaFriend = db.YamileOrellanaFriends.Find(id);
            db.YamileOrellanaFriends.Remove(yamileOrellanaFriend);
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
