namespace Ui.Front.App_Start
{
    using Bootstrap.Extensions.StartupTasks;
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig : IStartupTask
    {
        private RouteCollection routes;

        private RouteConfig(RouteCollection routes)
        {
            this.routes = routes;
        }

        public RouteConfig()
            : this(RouteTable.Routes)
        {

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
