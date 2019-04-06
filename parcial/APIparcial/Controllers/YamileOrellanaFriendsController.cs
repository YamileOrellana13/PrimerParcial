using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIparcial.Models;

namespace APIparcial.Controllers
{
    public class YamileOrellanaFriendsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/YamileOrellanaFriends
        public IQueryable<YamileOrellanaFriend> GetYamileOrellanaFriends()
        {
            return db.YamileOrellanaFriends;
        }

        // GET: api/YamileOrellanaFriends/5
        [ResponseType(typeof(YamileOrellanaFriend))]
        public IHttpActionResult GetYamileOrellanaFriend(int id)
        {
            YamileOrellanaFriend yamileOrellanaFriend = db.YamileOrellanaFriends.Find(id);
            if (yamileOrellanaFriend == null)
            {
                return NotFound();
            }

            return Ok(yamileOrellanaFriend);
        }

        // PUT: api/YamileOrellanaFriends/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutYamileOrellanaFriend(int id, YamileOrellanaFriend yamileOrellanaFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != yamileOrellanaFriend.FriendId)
            {
                return BadRequest();
            }

            db.Entry(yamileOrellanaFriend).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YamileOrellanaFriendExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/YamileOrellanaFriends
        [ResponseType(typeof(YamileOrellanaFriend))]
        public IHttpActionResult PostYamileOrellanaFriend(YamileOrellanaFriend yamileOrellanaFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.YamileOrellanaFriends.Add(yamileOrellanaFriend);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = yamileOrellanaFriend.FriendId }, yamileOrellanaFriend);
        }

        // DELETE: api/YamileOrellanaFriends/5
        [ResponseType(typeof(YamileOrellanaFriend))]
        public IHttpActionResult DeleteYamileOrellanaFriend(int id)
        {
            YamileOrellanaFriend yamileOrellanaFriend = db.YamileOrellanaFriends.Find(id);
            if (yamileOrellanaFriend == null)
            {
                return NotFound();
            }

            db.YamileOrellanaFriends.Remove(yamileOrellanaFriend);
            db.SaveChanges();

            return Ok(yamileOrellanaFriend);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool YamileOrellanaFriendExists(int id)
        {
            return db.YamileOrellanaFriends.Count(e => e.FriendId == id) > 0;
        }
    }
}