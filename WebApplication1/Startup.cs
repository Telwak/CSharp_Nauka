using Microsoft.Owin;
using Owin;
using System.Web.Mvc;

namespace WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
