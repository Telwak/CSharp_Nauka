using NHibernate;
using NHibernate.Linq;
using NHibernateMVC.Models;
using System.Linq;
using System.Web.Mvc;
using NHibernateMVC.Models;
using log4net;
using System;

namespace NHibernate.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
           
                using (ISession session = NHibernateSession.OpenSession())
                {

                    var persons = session.Query<Person>().ToList();
               
                    return View(persons);
                
                }
            
        }
        public ActionResult Create ()
        {
            return View("Create");
        }

        
        [HttpPost]
        public ActionResult Create(Person group)
        {
    try
    {
        using (var session = NHibernateSession.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                session.Save(group);
                tx.Commit();
                session.Close();
            }
            }
            catch (Exception a)
            {
                Logger.Error(a);
            }
            return View("Sucess_Create");
            
        }

        public ActionResult Delete()
        {
            return View("Delete");
        }

        [HttpPost]
        public ActionResult Delete(Person group)
        {
            try
            {

            
            using (var session = NHibernateSession.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                session.Delete(group);
                tx.Commit();
                session.Close();
            }
            }catch(Exception a)
            {
                Logger.Error(a);
            }
            return View("Sucess_Delete");
        }
        public ActionResult Edit ()
        {
            return View("Edit");
        }

        [HttpPost]
        public ActionResult Edit(Person group)
        {
            try
            {
                
            using (var session = NHibernateSession.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                
                session.Update(group);
                tx.Commit();
                session.Close();
            }
            }catch(Exception a)
            {
                Logger.Error(a);
            }
            return View("Sucess_Save");
        }
       
        public ActionResult Delete_all()
        {
            try { 
            using (var session = NHibernateSession.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                session.CreateSQLQuery("DELETE FROM Person").ExecuteUpdate();
                tx.Commit();
                session.Close();
            }
            }catch(Exception a)
            {
                Logger.Error(a);
            }
            return View("Sucess_Delete");
        }

    }
}