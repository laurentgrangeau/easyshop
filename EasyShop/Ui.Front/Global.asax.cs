namespace Ui.Front
{
    using Bootstrap;
    using Bootstrap.Extensions.StartupTasks;
    using Bootstrap.SimpleInjector;
    using System.Web;
    using System.Web.Mvc;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.With.SimpleInjector().And.StartupTasks().Start();
        }
    }
}
