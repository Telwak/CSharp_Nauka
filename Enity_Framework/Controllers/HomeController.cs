using Enity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enity_Framework.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            NTestEntities db = new NTestEntities();
            var Person = db.Person;
            
            return View(Person);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View("Add");
        }
       
        public ActionResult Add(Person Group)
        {
            NTestEntities db = new NTestEntities();
            var Person = db.Person;
            db.Person.Add(Group);
            db.SaveChanges();
            return View("Sucess");
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View("Edit");
        }

        public ActionResult Edit(Person Group)
        {
            NTestEntities db = new NTestEntities();
            var Person = db.Person;
            db.Person.Attach(Group);
            db.Entry(Group).State = EntityState.Modified;
            db.SaveChanges();
            return View("Sucess");
        }
        public ActionResult Delete(Person Group)
        {
            NTestEntities db = new NTestEntities();
            var Person = db.Person;
            db.Person.Attach(Group);
            db.Person.Remove(Group);
            db.SaveChanges();
            return View("Sucess");
        }
        public ActionResult Delete_all(Person Group)
        {
            NTestEntities db = new NTestEntities();
            var Person = db.Person;
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Person]");
            db.SaveChanges();
            return View("Sucess");
        }

    }
}