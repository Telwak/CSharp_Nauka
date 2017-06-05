using NHibernate;
using System.Web;
using NHibernate.Cfg;
namespace NHibernateMVC.Models
{
    public class NHibernateSession
    {

        public static  ISession OpenSession()
        {
            
                var configuration = new Configuration();
                var configurationPath = HttpContext.Current.Server.MapPath(@"~\hibernate.cfg.xml");
                configuration.Configure(configurationPath);
                var configurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Person.hbm.xml");
                configuration.AddFile(configurationFile);
                ISessionFactory sessionFactory = configuration.BuildSessionFactory();
                return sessionFactory.OpenSession();

      
            
        }
    }
}